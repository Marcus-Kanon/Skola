using System.ComponentModel;

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
        public ICollection<Inventories_Ingredients> Inventories_Ingredients { get; set; } = null!;
        public ICollection<ShoppingLists_Ingredients> ShoppingLists_Ingredients { get; set; } = null!;
    }
}
