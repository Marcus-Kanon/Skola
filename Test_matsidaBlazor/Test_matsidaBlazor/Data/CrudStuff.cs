using Test_matsidaBlazor.Data.Models;

namespace Test_matsidaBlazor.Data
{
    public static class CrudStuff
    {
        static DataContext _context = new();
        static List<Recipe> _recipes = new();

        public static Recipe GetRecipe(int id)
        {

            Recipe? recipe = null;

            if (_context != null)
            {
                recipe = _context.Recipes.FirstOrDefault(q => q.Id == id);
            }

            if (recipe != null)
            {
                return recipe;
            }


            return new Recipe();
        }

        public static List<Ingredient> GetIngredients(int id)
        {
            var recipes_ingredients = _context.Recipes_Nutrients.Where(q => q.RecipeId == id).ToList();
            var ingredients=recipes_ingredients.Select(s => s.Ingredient).ToList();

            return ingredients;
        }

        public static List<Recipe> SearchRecipes(string search)
        {
            List<Recipe> results = new();

            if (search != "")
            {
                results = _recipes.FindAll(q => q.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            return results;
        }

        public static void LoadRecipes()
        {
            _recipes = _context.Recipes.ToList();
        }

        public static void LoadContext(DataContext context)
        {
            _context = context;
        }
    }
}
