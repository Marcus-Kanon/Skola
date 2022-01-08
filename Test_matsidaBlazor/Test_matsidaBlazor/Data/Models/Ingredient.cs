namespace Test_matsidaBlazor.Data.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Density { get; set; }
        public ICollection<Recipes_Ingredients> Recipes_Ingredients { get; set; } = null!;
        public int NutrientsId { get; set; }
        public Nutrients? Nutrients { get; set; }
        public ICollection<Inventory>? Inventories { get; set; }
    }
}
