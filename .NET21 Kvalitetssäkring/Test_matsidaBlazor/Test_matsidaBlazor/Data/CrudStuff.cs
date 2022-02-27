using Microsoft.EntityFrameworkCore;
using Test_matsidaBlazor.Data.Models;
using System.Linq;
using System.Text;

namespace Test_matsidaBlazor.Data
{
    public class CrudStuff
    {
        static CrudStuff Instance = null!;
        DataContext Context = default!;

        /// <summary>
        /// Private constructor in order to avoid it being accessed outside the class. Singleton.
        /// </summary>
        private CrudStuff()
        {
            
        }
        /// <summary>
        /// Returns current instance.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static CrudStuff GetInstance()
        {
            return Instance ?? throw new Exception("Class hasn't been Initiated. Call Initialize(DbContext context)."); ;
        }
        /// <summary>
        /// Initializes the instance. This must be called before calling GetInstance().
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static CrudStuff Initialize(DataContext context)
        {
            return Instance ??= new CrudStuff { Context = context };
        }
        /// <summary>
        /// Adds initial ingredients to the database
        /// </summary>
        public void FillUpIngredientTable()
        {
            if(!GetInstance().Context.Ingredients.Any())
            {
                List<Ingredient> ingredients = new ();

                ingredients.Add(new Ingredient { Name = "Lök", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Mjölk", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Mjöl", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Yoghurt", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Lök", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Potatis", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Morot", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Ris", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Spaghetti", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Jordgubbssylt", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Fésk", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Köttfärs", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Marabou", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Svartpeppar", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Korv, massa korv", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Billy's Pan pizza", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Chips", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Tunnbröd", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Ost", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Socker", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Donuts", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Sallad", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Tomat", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Äpplen", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Curry", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Havre", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });
                ingredients.Add(new Ingredient { Name = "Snickers", Density = 6.6, Nutrients = new Nutrients { VitA = 3.3, VitB = 4.4, VitC = 5.5 } });


                foreach (var item in ingredients)
                {
                    GetInstance().Context.Ingredients.Add(item);

                    Console.WriteLine("Adding: " + item.Name);
                }

                GetInstance().Context.SaveChanges();
            }
        }

        //Shared Crud operations

        /// <summary>
        /// Returns recipe of specific id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Recipe GetRecipe(int id)
        {
            return GetInstance().Context.Recipes.FirstOrDefault(q => q.Id == id) ?? new Recipe();
        }
        /// <summary>
        /// Returns List of Ingredients in recipe with specific id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Recipes_Ingredients> GetIngredients(int id)
        {
            var recipes_ingredients = GetInstance().Context.Recipes_Inredients
                .Include(p => p.Ingredient)
                .Where(q => q.RecipeId == id)
                .ToList();

            return recipes_ingredients;
        }
        /// <summary>
        /// Returns a List of recipes whose names contain specified string.
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Returns a List of ingredients whose names contain specified string.
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Returns true if the specified Ingredient-Object is listed as an ingredient in the database.
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns></returns>
        public bool CheckValidIngredient(Ingredient ingredient)
        {
            var result = GetInstance().Context.Ingredients
                .Where(p => p == ingredient)
                .SingleOrDefault();

            return result != null;
        }
        /// <summary>
        /// Returns a List of all Ingredients in a User's inventory where inventoryId is the id of the inventory.
        /// </summary>
        /// <param name="tracker"></param>
        /// <param name="inventoryId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Ingredient> GetIngredientsInInventory(LoginTracker? tracker, int inventoryId)
        {
            if (!CheckValidTracker(tracker))
                throw new Exception("NOT LOGGED IN");

            var user = TrackerToUser(tracker);
            var inventories = GetUserInventories(user);

            if (inventories.Count == 0)
            {
                MakeNewInventory(user);
                inventories = GetUserInventories(user);
            }

            CorrectInventoryId(inventoryId, inventories.Count);

            return inventories[inventoryId].Inventories_Ingredients
                .Select(s => s.Ingredient)
                .ToList();
        }

        //Login Crud

        /// <summary>
        /// Adds a user to the database
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public void AddUser(string name, string password)
        {
            GetInstance().Context.Users.Add(new User { Username = name, Password = password });

            GetInstance().Context.SaveChanges();
        }

        /// <summary>
        /// Takes a Tracker-object, finds the corresponding User in the database and returns it.
        /// </summary>
        /// <param name="tracker"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public User TrackerToUser(LoginTracker? tracker)
        {
            if (tracker == null)
                throw new Exception("Tracker is null. Consider using CheckValidTracker before calling TrackerToUser.");

            return GetInstance().Context.Users
                .Where(q => q.Username == tracker.Username && q.Password == q.Password)
                .SingleOrDefault() ?? throw new Exception("No User corresponds to session data");
        }
        
        /// <summary>
        /// Checks if there is a matching User in the DB
        /// </summary>
        /// <param name="userDetails"></param>
        /// <returns></returns>
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
        
        /// <summary>
        /// Generates a random Tracker-key
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Checks if there is any corresponding Tracker in the DB
        /// </summary>
        /// <param name="tracker"></param>
        /// <returns></returns>
        public bool CheckValidTracker(LoginTracker? tracker)
        {
            if(tracker == null)
                return false;

            var results = GetInstance().Context.LoginTrackers
                .Where(q => q == tracker)
                .SingleOrDefault();

            return results != null;
        }
        /// <summary>
        /// Checks if a username has already been used.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckUsernameExists(string name) => GetInstance().Context.Users.Where(p => p.Username == name).Any();


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

            return inventory;
        }
        /// <summary>
        /// Returns a User's Inventory
        /// </summary>
        /// <param name="user"></param>
        /// <param name="inventoryId">Id of Inventory</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
        /// <summary>
        /// Returns how many Inventories a User has
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int GetNumberOfInventories(User user)
        {
            var context = GetInstance().Context;
            int count = context.Inventories
                .Include(p => p.User)
                .Where(p => p.User == user)
                .Count();

            return count;
        }
        /// <summary>
        /// Adds an ingredient to the Inventory
        /// </summary>
        /// <param name="tracker"></param>
        /// <param name="ingredient"></param>
        /// <param name="inventoryId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
        /// <summary>
        /// Creates a template object of type "Inventories_Ingredients"
        /// </summary>
        /// <param name="ingredient"></param>
        /// <param name="inventory"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Checks if Ingredient exists in given Inventory
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ingredient"></param>
        /// <param name="inventoryId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Removes Ingredient from Inventory
        /// </summary>
        /// <param name="tracker"></param>
        /// <param name="ingredient"></param>
        /// <param name="inventoryId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
        /// <summary>
        /// Returns a List of all Inventories a User has.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
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
            {
                MakeNewShoppingList(user);
                shoppingLists = GetUserShoppingLists(user);
            }

            CorrectShoppingListId(id, shoppingLists.Count);

            return shoppingLists[id].ShoppingLists_Ingredients
                .Select(s => s.Ingredient)
                .ToList();
        }
        /// <summary>
        /// Adjusts the ShoppingList element identifier so that it won't exceed the minimum or maximum value
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
        /// Adds a new ShoppingList to the user
        /// </summary>
        /// <param name="user">User to add ShoppingList to</param>
        /// <returns></returns>
        public ShoppingList MakeNewShoppingList(User user)
        {
            const int numberOfIngrediensToStartWith = 3;
            var context = GetInstance().Context;
            var ingredients = context.Ingredients.Take(numberOfIngrediensToStartWith).ToList();
            var shoppingList = new ShoppingList { User = user };

            if (ingredients.Any())
            {
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
            }

            context.ShoppingLists.Add(shoppingList);
            context.SaveChanges();

            return shoppingList;
        }
        /// <summary>
        /// Returns a User's Inventory
        /// </summary>
        /// <param name="user"></param>
        /// <param name="inventoryId">Id of ShoppingList</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
        /// <summary>
        /// Returns how many ShoppingLists a User has
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int GetNumberOfShoppingLists(User user)
        {
            var context = GetInstance().Context;
            int count = context.ShoppingLists
                .Include(p => p.User)
                .Where(p => p.User == user)
                .Count();

            return count;
        }
        /// <summary>
        /// Adds an ingredient to the ShoppingList
        /// </summary>
        /// <param name="tracker"></param>
        /// <param name="ingredient"></param>
        /// <param name="inventoryId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
        /// <summary>
        /// Creates a template object of type "ShoppingLists_Ingredients"
        /// </summary>
        /// <param name="ingredient"></param>
        /// <param name="inventory"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Checks if Ingredient exists in given ShoppingList
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ingredient"></param>
        /// <param name="inventoryId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Removes Ingredient from ShoppingList
        /// </summary>
        /// <param name="tracker"></param>
        /// <param name="ingredient"></param>
        /// <param name="inventoryId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
                var shoppingList = GetShoppingList(user, id);
                var ii = context.ShoppingLists_Ingredients
                    .Where(p => p.Ingredient == ingredient && p.ShoppingList == shoppingList)
                    .Single();

                shoppingList.ShoppingLists_Ingredients
                    .Remove(ii);

                context.SaveChanges();

                return true;
            }

            return false;
        }
        /// <summary>
        /// Returns a List of all ShoppingLists a User has.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
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