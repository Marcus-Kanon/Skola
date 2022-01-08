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

                return inventories[inventoryId].Ingredients.ToList();
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
                Ingredients=ingredients,
                Amount=5.0,
            };

            context.Inventories.Add(inventory);
            context.SaveChanges();

            return inventory;
        }

        public bool AddInventoryItem(User user, Ingredient ingredient, int inventoryId)
        {
            var context = GetInstance().Context;

            if (CheckLoginDetails(user))
            {
                var inventories = GetUserInventories(user);
                var checkIngredient = context.Ingredients.Where(q => q == ingredient).Single();

                inventories[inventoryId].Ingredients.Add(checkIngredient);

                context.SaveChanges();

                return true;
            }
            else
            {
                throw new Exception("No inventory associated with user.");
            }
        }

        public bool RemoveInventoryItem(LoginTracker tracker, Ingredient ingredient, int inventoryId)
        {
            if (CheckValidTracker(tracker))
            {
                var user = TrackerToUser(tracker) ?? throw new Exception("Tracker is valid but does not correspond with a user in the database");

                var inventories = GetUserInventories(user);

                inventories[inventoryId].Ingredients.Remove(ingredient);

                GetInstance().Context.SaveChanges();

                return true;
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
                    .Include(p => p.Ingredients)
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
