using Microsoft.EntityFrameworkCore;
using Test_matsidaBlazor.Data.Models;
using System.Linq;

namespace Test_matsidaBlazor.Data
{
    public class CrudStuff
    {
        static CrudStuff Instance;
        DataContext Context;

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
            if(Instance==null)
            {
                Instance = new CrudStuff();
                Instance.Context = context;
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

        public List<Ingredient> GetIngredientsInInventory(User user, int inventoryId)
        {
            if(CheckLoginDetails(user))
            {
                var inventory = GetUserInventory(user);

                if(inventory != null)
                {
                    return inventory.Ingredients.ToList();
                }
            }

            return new List<Ingredient>();
        }

        public bool AddInventoryItem(User user, int inventoryId, Ingredient ingredient)
        {
            if (CheckLoginDetails(user))
            {
                var inventory = GetUserInventory(user, inventoryId);

                if(inventory != null)
                {
                    inventory.Ingredients.Add(ingredient);
                }

                GetInstance().Context.SaveChanges();

                return true;
            }
            else
            {
                throw new Exception("No inventory associated with user.");
            }
        }

        public bool RemoveInventoryItem(User user, int inventoryId, Ingredient ingredient)
        {
            if (CheckLoginDetails(user))
            {
                var inventory = GetUserInventory(user, inventoryId);

                if (inventory != null)
                {
                    inventory.Ingredients.Remove(ingredient);
                }

                GetInstance().Context.SaveChanges();

                return true;
            }
            else
            {
                throw new Exception("No inventory associated with user.");
            }
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
            GetInstance().Context.LoginTrackers.Add(new LoginTracker
            {
                Username = login.Username,
                Password = login.Password,
                Created = DateTime.Now,
                LastUsed = DateTime.Now,
                Key = 
            });
        }

        private string GenerateLoginKey()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVXYZabcdefghijklnopqrstuvxyz123456789#%&()=?";

            for (int i = 0; i < length; i++)
            {

            }
            var key = 
        }

        private Inventory? GetUserInventory(User user, int inventoryId = 0)
        {
            return GetInstance().Context.Inventories
                    .Include(p => p.Ingredients)
                    .Where((q, i) => q.User == user && i == inventoryId).SingleOrDefault();
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
