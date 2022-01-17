﻿using Microsoft.EntityFrameworkCore;
using Test_matsidaBlazor.Data.Models;
using System.Linq;
using System.Text;

namespace Test_matsidaBlazor.Data
{
    public class CrudStuff
    {
        static CrudStuff Instance = null!;
        DataContext Context = default!;

        private CrudStuff()
        {
            
        }

        public static CrudStuff GetInstance()
        {
            return Instance ?? throw new Exception("Class hasn't been Initiated. Call Initialize(DbContext context)."); ;
        }

        public static CrudStuff Initialize(DataContext context)
        {
            return Instance ??= new CrudStuff { Context = context };
        }

        public Recipe GetRecipe(int id)
        {
            return GetInstance().Context.Recipes.FirstOrDefault(q => q.Id == id) ?? new Recipe();
        }

        public List<Recipes_Ingredients> GetIngredients(int id)
        {
            var recipes_ingredients = GetInstance().Context.Recipes_Inredients
                .Include(p => p.Ingredient)
                .Where(q => q.RecipeId == id)
                .ToList();

            return recipes_ingredients;
        }

        public List<Recipe> SearchRecipesByName(string search)
        {
            var recipes = GetInstance().Context.Recipes
                .AsNoTracking()
                .Where(p => p.Name.Contains(search))
                .OrderBy(p => p.Name)
                .Take(10)
                .ToList();

            return recipes;
        }
        public List<Ingredient> SearchIngredientsByName(string search)
        {
            var ingredients = GetInstance().Context.Ingredients
                .AsNoTracking()
                .Where(p => p.Name.Contains(search))
                .OrderBy(p => p.Name)
                .Take(10)
                .ToList();

            return ingredients;
        }

        public bool CheckValidIngredient(Ingredient ingredient)
        {
            var result = GetInstance().Context.Ingredients
                .Where(p => p == ingredient)
                .SingleOrDefault();

            return result != null;
        }

        //Login Crud
        public void AddUser(string name, string password)
        {
            GetInstance().Context.Users.Add(new User { Username = name, Password = password });

            GetInstance().Context.SaveChanges();
        }

        public User TrackerToUser(LoginTracker? tracker)
        {
            if (tracker == null)
                throw new Exception("Tracker is null. Consider using CheckValidTracker before calling TrackerToUser.");

            return GetInstance().Context.Users
                .Where(q => q.Username == tracker.Username && q.Password == q.Password)
                .SingleOrDefault() ?? throw new Exception("No User corresponds to session data");
        }

        public bool CheckLoginDetails(User userDetails)
        {
            var user = GetInstance().Context.Users
                .FirstOrDefault(q => q.Username == userDetails.Username && q.Password == userDetails.Password);

            return user != null;
        }

        /// <summary>
        /// Adds a record to the DB which can be used to track if a user is logged-in
        /// </summary>
        /// <param name="login">User to add track for.</param>
        /// <returns></returns>
        public LoginTracker GenerateLoginTracker(User login)
        {
            var tracker = new LoginTracker
            {
                Username = login.Username,
                Password = login.Password,
                Created = DateTime.Now,
                LastUsed = DateTime.Now,
                Key = GenerateLoginKey()
            };

            GetInstance().Context.LoginTrackers.Add(tracker);
            GetInstance().Context.SaveChanges();

            return tracker;
        }
        private static string GenerateLoginKey()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVXYZabcdefghijklnopqrstuvxyz123456789#%&()=?";
            Random rnd = new();
            StringBuilder key = new();

            for (int i = 0; i < 32; i++)
            {
                key.Append(characters[rnd.Next(0, characters.Length)]);
            }

            return key.ToString();
        }

        public bool CheckValidTracker(LoginTracker? tracker)
        {
            if(tracker == null)
                return false;

            var results = GetInstance().Context.LoginTrackers
                .Where(q => q == tracker)
                .SingleOrDefault();

            return results != null;
        }

        public List<Ingredient?> GetIngredientsInInventory(LoginTracker? tracker, int inventoryId)
        {
            if (!CheckValidTracker(tracker))
                throw new Exception("NOT LOGGED IN");

            var user = TrackerToUser(tracker);
            var inventories = GetUserInventories(user);

            if (inventories.Count == 0)
            {
                inventories.Add(MakeNewInventory(user));
            }

            CorrectInventoryId(inventoryId, inventories.Count);

            return inventories[inventoryId].Inventories_Ingredients 
                .Select(s => s.Ingredient)
                .DefaultIfEmpty(null)
                .ToList();
        }

        //Inventory Crud
        /// <summary>
        /// Adjusts the inventory element identifier so that it won't exceed the minimum or maximum value
        /// </summary>
        /// <param name="inventoryId">Value to adjust</param>
        /// <param name="count">Number of inventories</param>
        /// <returns></returns>
        private static int CorrectInventoryId(int inventoryId, int count)
        {
            if (inventoryId >= count)
                inventoryId = 0;

            if (inventoryId < 0)
                inventoryId = count - 1;

            return inventoryId;
        }

        /// <summary>
        /// Adds a new inventory to the user
        /// </summary>
        /// <param name="user">User to add inventory to</param>
        /// <returns></returns>
        public Inventory MakeNewInventory(User user)
        {
            const int numberOfIngrediensToStartWith = 0;
            var context = GetInstance().Context;

            var ingredients = context.Ingredients.Take(numberOfIngrediensToStartWith).ToList();
            var inventory = new Inventory { User = user };

            if(ingredients.Any())
            {
                foreach (Ingredient ingredient in ingredients)
                {
                    context.Inventories_Ingredients.Add(new Inventories_Ingredients()
                    {
                        Inventory = inventory,
                        Ingredient = ingredient,
                        Amount = 5.0,
                        Unit = "gram"
                    });
                }
            }

            context.Inventories.Add(inventory);
            context.SaveChanges();

            return inventory ?? throw new Exception("Inventory is null");
        }

        public Inventory GetInventory(User? user, int inventoryId)
        {
            if (user != null)
            {
                var context = GetInstance().Context;
               Inventory inventory = context.Inventories
                    .Find(user.Inventories
                        .ElementAt(inventoryId).Id) ?? throw new Exception("No Inventory Found");

                return inventory;
            }
            else
            {
                throw new Exception("user is null");
            }
        }

        public int GetNumberOfInventories(User user)
        {
            var context = GetInstance().Context;
            int count = context.Inventories
                .Include(p => p.User)
                .Where(p => p.User == user)
                .Count();

            return count;
        }

        public bool AddInventoryItem(LoginTracker tracker, Ingredient ingredient, int inventoryId)
        {
            if (!CheckValidTracker(tracker))
                return false;

            if (!CheckValidIngredient(ingredient))
                return false;

            var context = GetInstance().Context;
            var user = TrackerToUser(tracker);
            Ingredient item;
            Inventory inventory = GetInventory(user, inventoryId);

            if (!CheckIngredientExistsInInventory(user, ingredient, inventoryId))
            {
                item = context.Ingredients
                    .Find(ingredient.Id) ?? throw new Exception("Could not find matching ingredient");

                var ii = CreateInventoriesIngredients(item, inventory);

                inventory.Inventories_Ingredients.Add(ii);

                context.SaveChanges();

                return true;
            }

            return false;
        }

        public Inventories_Ingredients CreateInventoriesIngredients(Ingredient ingredient, Inventory inventory)
        {
            return new Inventories_Ingredients
            {
                Ingredient = ingredient,
                Inventory = inventory,
                Amount = 500,
                Unit = "gram"

            };
        }

        public bool CheckIngredientExistsInInventory(User? user, Ingredient ingredient, int inventoryId)
        {
            var context = GetInstance().Context;

            var item = context.Ingredients
                .Find(ingredient.Id) ?? throw new Exception("Could not find requested ingredient");

            var result = context.Inventories_Ingredients
                .Where(p => p.Inventory == GetInventory(user, inventoryId) && p.Ingredient == item)
                .SingleOrDefault();

            return result != null;
        }


        public bool RemoveInventoryItem(LoginTracker? tracker, Ingredient ingredient, int inventoryId)
        {
            if (!CheckValidTracker(tracker))
                throw new Exception("Could not find tracker in database");

            if (!CheckValidIngredient(ingredient))
                return false;

            var user = TrackerToUser(tracker);
            var context = GetInstance().Context;

            if (CheckIngredientExistsInInventory(user, ingredient, inventoryId))
            {
                var inventory = GetInventory(user, inventoryId);
                var ii = context.Inventories_Ingredients
                    .Where(p => p.Ingredient == ingredient && p.Inventory == inventory)
                    .Single();

                inventory.Inventories_Ingredients
                    .Remove(ii);

                context.SaveChanges();

                return true;
            }

            return false;
        }

        private static List<Inventory> GetUserInventories(User user)
        {
            var inventories = GetInstance().Context.Inventories
                    .Include(p => p.Inventories_Ingredients)
                    .ThenInclude(p => p.Ingredient)
                    .Where(q => q.User == user).ToList();

            return inventories;
        }

        //Shopping list Crud
        public List<Ingredient> GetIngredientsInShoppingList(LoginTracker tracker, int id)
        {
            if (!CheckValidTracker(tracker))
                throw new Exception("NOT LOGGED IN");

            var user = TrackerToUser(tracker);
            var shoppingLists = GetUserShoppingLists(user);

            if (shoppingLists.Count == 0)
                shoppingLists.Add(MakeNewShoppingList(user));

            CorrectShoppingListId(id, shoppingLists.Count);

            return shoppingLists[id].ShoppingLists_Ingredients
                .Select(s => s.Ingredient)
                .ToList();
        }
        /// <summary>
        /// Adjusts the inventory element identifier so that it won't exceed the minimum or maximum value
        /// </summary>
        /// <param name="inventoryId">Value to adjust</param>
        /// <param name="count">Number of inventories</param>
        /// <returns></returns>
        private static int CorrectShoppingListId(int id, int count)
        {
            if (id >= count)
                id = 0;

            if (id < 0)
                id = count - 1;

            return id;
        }

        /// <summary>
        /// Adds a new inventory to the user
        /// </summary>
        /// <param name="user">User to add inventory to</param>
        /// <returns></returns>
        public ShoppingList MakeNewShoppingList(User user)
        {
            const int numberOfIngrediensToStartWith = 5;
            var context = GetInstance().Context;
            var ingredients = context.Ingredients.Take(numberOfIngrediensToStartWith).ToList();
            var shoppingList = new ShoppingList { User = user };

            foreach (Ingredient ingredient in ingredients)
            {
                context.ShoppingLists_Ingredients.Add(new ShoppingLists_Ingredients()
                {
                    ShoppingList = shoppingList,
                    Ingredient = ingredient,
                    Amount = 4.0,
                    Unit = "gram"
                });
            }
            context.ShoppingLists.Add(shoppingList);
            context.SaveChanges();

            return shoppingList;
        }

        public ShoppingList GetShoppingList(User? user, int id)
        {
            if(user != null)
            {
                var context = GetInstance().Context;
                var shoppingList = context.ShoppingLists
                    .Find(user.ShoppingLists
                        .ElementAt(id).Id) ?? throw new Exception("No Inventory Found");

                return shoppingList;
            }
            else
            {
                throw new Exception("user is null");
            }
        }

        public int GetNumberOfShoppingLists(User user)
        {
            var context = GetInstance().Context;
            int count = context.ShoppingLists
                .Include(p => p.User)
                .Where(p => p.User == user)
                .Count();

            return count;
        }

        public bool AddShoppingListItem(LoginTracker? tracker, Ingredient ingredient, int id)
        {
            if(!CheckValidTracker(tracker))
                return false;

            if (!CheckValidIngredient(ingredient))
                return false;

            var context = GetInstance().Context;
            User user = TrackerToUser(tracker);
            Ingredient item;
            ShoppingList shoppingList = GetShoppingList(user, id);

            if (!CheckIngredientExistsInShoppingList(user, ingredient, id))
            {
                item = context.Ingredients
                    .Find(ingredient.Id) ?? throw new Exception("Could not find matching ingredient");

                var ii = CreateShoppingListsIngredients(item, shoppingList);

                shoppingList.ShoppingLists_Ingredients.Add(ii);

                context.SaveChanges();

                return true;
            }

            return false;
        }

        public ShoppingLists_Ingredients CreateShoppingListsIngredients(Ingredient ingredient, ShoppingList shoppingList)
        {
            return new ShoppingLists_Ingredients
            {
                Ingredient = ingredient,
                ShoppingList = shoppingList,
                Amount = 500,
                Unit = "gram"

            };
        }

        public bool CheckIngredientExistsInShoppingList(User user, Ingredient ingredient, int id)
        {
            var context = GetInstance().Context;

            var item = context.Ingredients
                .Find(ingredient.Id) ?? throw new Exception("Could not find requested ingredient");

            var result = context.ShoppingLists_Ingredients
                .Where(p => p.ShoppingList == GetShoppingList(user, id) && p.Ingredient == item)
                .SingleOrDefault();

            return result != null;
        }


        public bool RemoveShoppingListItem(LoginTracker? tracker, Ingredient ingredient, int id)
        {
            if (!CheckValidTracker(tracker))
                throw new Exception("Could not find tracker in database");

            if (!CheckValidIngredient(ingredient))
                return false;

            var user = TrackerToUser(tracker);
            var context = GetInstance().Context;

            if (CheckIngredientExistsInShoppingList(user, ingredient, id))
            {
                var shoppingList = GetInventory(user, id);
                var ii = context.Inventories_Ingredients
                    .Where(p => p.Ingredient == ingredient && p.Inventory == shoppingList)
                    .Single();

                shoppingList.Inventories_Ingredients
                    .Remove(ii);

                context.SaveChanges();

                return true;
            }

            return false;
        }

        private static List<ShoppingList> GetUserShoppingLists(User user)
        {
            var shoppingLists = GetInstance().Context.ShoppingLists
                    .Include(p => p.ShoppingLists_Ingredients)
                    .ThenInclude(p => p.Ingredient)
                    .Where(q => q.User == user).ToList();

            return shoppingLists;
        }
    }
}
