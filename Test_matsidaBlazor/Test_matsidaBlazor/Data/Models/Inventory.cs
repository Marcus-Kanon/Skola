namespace Test_matsidaBlazor.Data.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int IngredientId { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; } = null!;
        public double Amount { get; set; }
        public ICollection<Inventories_Ingredients> Inventories_Ingredients { get; set; } = null!;
    }
}
