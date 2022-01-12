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

        private CrudStuff()
        {
            
        }

        public static CrudStuff GetInstance()
        {
            if(Instance!=null)
            {
                return Instance;
            }
            else
            {
                throw new Exception("Class hasn't been Initiated. Call Initialize(DbContext context).");
            }
        }

        public static CrudStuff Initialize(DataContext context)
        {
            if(Instance == null)
            {
                Instance = new CrudStuff
                {
                    Context = context
                };
            }

            return Instance;
        }

        public Recipe GetRecipe(int id)
        {

            Recipe? recipe = null;

            recipe = GetInstance().Context.Recipes.FirstOrDefault(q => q.Id == id);


            if (recipe != null)
            {
                return recipe;
            }


            return new Recipe();
        }

        public List<Recipes_Ingredients> GetIngredients(int id)
        {
            var recipes_ingredients = GetInstance().Context.Recipes_Inredients.Include(p => p.Ingredient).Where(q => q.RecipeId == id);

            return recipes_ingredients.ToList();
        }

        public List<Recipe> SearchRecipesByName(string search)
        {
            var results = GetInstance().Context.Recipes
                .AsNoTracking()
                .Where(p => p.Name.Contains(search))
                .OrderBy(p => p.Name)
                .Take(10)
                .ToList();

            return results;
        }
        public List<Ingredient> SearchIngredientsByName(string search)
        {
            var results = GetInstance().Context.Ingredients
                .AsNoTracking()
                .Where(p => p.Name.Contains(search))
                .OrderBy(p => p.Name)
                .Take(10)
                .ToList();

            return results;
        }

        public void AddUser(string name, string password)
        {
            GetInstance().Context.Users.Add(new User{ Username = name, Password = password });

            GetInstance().Context.SaveChanges();
        }

        public List<Ingredient> GetIngredientsInInventory(LoginTracker tracker, int inventoryId)
        {
            if(CheckValidTracker(tracker))
            {
                var user = TrackerToUser(tracker) ?? throw new Exception("No User corresponds to session data");

                var inventories = GetUserInventories(user);

                if(inventories.Count == 0)
                    inventories.Add(MakeNewInventory(user));

                if (inventoryId >= inventories.Count)
                    inventoryId = 0;

                if (inventoryId < 0)
                    inventoryId = inventories.Count-1;

                return inventories[inventoryId].Inventories_Ingredients.Select(s => s.Ingredient).ToList();
            }
            else
            {
                throw new Exception("NOT LOGGED IN");
            }
        }

        public Inventory MakeNewInventory(User user)
        {
            var context = GetInstance().Context;
            var ingredients = context.Ingredients.Take(5).ToList();
            var inventory = new Inventory
            {
                User=user,
            };

            foreach(Ingredient ingredient in ingredients)
            {
                context.Inventories_Ingredients.Add(new Inventories_Ingredients()
                {
                    Inventory = inventory,
                    Ingredient=ingredient,
                    Amount = 5.0,
                });
            }


            context.Inventories.Add(inventory);
            context.SaveChanges();

            return inventory;
        }

        public Inventory GetInventory(User user, int inventoryId)
        {
            var context = GetInstance().Context;
            Inventory inventory = context.Inventories.Find(
                user.Inventories.ElementAt(inventoryId).Id
                );

            if(inventory != null)
            {
                return inventory;
            }
            else
            {
                throw new Exception("No Inventory Found");
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
            var context = GetInstance().Context;
            var user = TrackerToUser(tracker);
            Ingredient item;
            Inventory inventory = GetInventory(user, inventoryId);

            if(CheckValidIngredient(ingredient) && !CheckIngredientExistsInInventory(user, ingredient, inventoryId))
            {
                item = context.Ingredients.Find(ingredient.Id) ?? throw new Exception("Could not find matching ingredient");

                var i_i = new Inventories_Ingredients
                {
                    Ingredient = item,
                    Inventory = inventory,
                    Amount = 500,
                    Unit = "gram"
                    
                };

                //Context.Inventories_Ingredients.Add(i_i);//TODO: testa utan denna raden
                inventory.Inventories_Ingredients.Add(i_i);

                context.SaveChanges();

                return true;
            }

            return false;
        }

        public bool CheckIngredientExistsInInventory(User user, Ingredient ingredient ,int inventoryId)
        {
            var context = GetInstance().Context;

            var item = context.Ingredients.Find(ingredient.Id) ?? throw new Exception("Could not find requested ingredient");
            var result = context.Inventories_Ingredients.Where(p => p.Inventory == GetInventory(user, inventoryId) && p.Ingredient==item).SingleOrDefault();

            if(result != null)
                return true;

            Console.WriteLine("Item exists " + ingredient.Name);
            return false;

        }

        public bool CheckValidIngredient(Ingredient ingredient)
        {
            var result = GetInstance().Context.Ingredients.Where(p => p == ingredient).SingleOrDefault();

            if(result!=null)
            {
                return true;
            }

            return false;
        }

        public bool RemoveInventoryItem(LoginTracker tracker, Ingredient ingredient, int inventoryId)
        {
            
            if (CheckValidTracker(tracker))
            {
                var user = TrackerToUser(tracker) ?? throw new Exception("Tracker is valid but does not correspond with a user in the database");
                var context = GetInstance().Context;

                if (CheckIngredientExistsInInventory(user, ingredient, inventoryId))
                {
                    var inventory = GetInventory(user, inventoryId);

                    var ii = context.Inventories_Ingredients.Where(p => p.Ingredient == ingredient && p.Inventory==inventory).SingleOrDefault();

                    inventory.Inventories_Ingredients.Remove(ii);
                    context.SaveChanges();

                    return true;
                }
                else
                {
                    Console.WriteLine("Could not find ingredient to remove.");
                    return false;
                }
                
                
            }
            else
            {
                throw new Exception("Could not find tracker in database");
            }
        }

        public User? TrackerToUser(LoginTracker tracker)
        {
            return GetInstance().Context.Users.Where(q => q.Username == tracker.Username && q.Password == q.Password).SingleOrDefault();
        }

        public bool CheckLoginDetails(User userDetails)
        {
            var user = GetInstance().Context.Users.FirstOrDefault(q => q.Username == userDetails.Username && q.Password == userDetails.Password);

            if (user != null)
            {
                return true;
            }

            return false;
        }

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
        
        public bool CheckValidTracker(LoginTracker? tracker)
        {
            if(tracker == null)
            {
                Console.WriteLine("Tracker is null");
                return false;
            }

            var results = GetInstance().Context.LoginTrackers.Where(q => q == tracker).SingleOrDefault();

            if(results != null)
            {
                if(true) //TODO: Lägg till tidsbegränsning
                {
                    return true;
                }
            }

            return false;
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

        private static List<Inventory> GetUserInventories(User user)
        {
            var results = GetInstance().Context.Inventories
                    .Include(p => p.Inventories_Ingredients)
                    .ThenInclude(p => p.Ingredient)
                    .Where(q => q.User == user).ToList();

            return results;
        }

        /*
        public List<Recipe> SearchRecipesByIngredient(string search)
        {
            var results = GetInstance().Context.Recipes
                .Include(p => p.Recipes_Ingredients)
                .ThenInclude(p => p.Ingredient)
                .AsNoTracking()
                .Where(q => q.)
                .OrderBy(p => p.Ingredient.Name)
                .Take(10)
                .ToList();

            return results;
        }*/
    }
}
