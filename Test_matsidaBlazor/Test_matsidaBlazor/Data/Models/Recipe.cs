namespace Test_matsidaBlazor.Data.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Recipes_Ingredients> Recipes_Ingredients { get; set; }

    }
}
