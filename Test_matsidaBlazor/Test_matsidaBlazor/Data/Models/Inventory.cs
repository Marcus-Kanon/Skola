namespace Test_matsidaBlazor.Data.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int IngredientId { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public double Amount { get; set; }

    }
}
