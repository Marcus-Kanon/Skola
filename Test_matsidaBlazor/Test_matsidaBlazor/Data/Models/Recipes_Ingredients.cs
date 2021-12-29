namespace Test_matsidaBlazor.Data.Models
{
    public class Recipes_Ingredients
    {
        public int Id { get; set; }
        public double IngredientWeight { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
