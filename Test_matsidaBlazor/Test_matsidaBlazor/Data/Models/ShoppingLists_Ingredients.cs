namespace Test_matsidaBlazor.Data.Models
{
    public class ShoppingLists_Ingredients
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public int IngredientId { get; set; }
        public ShoppingList ShoppingList { get; set; }
        public Ingredient Ingredient { get; set; }
        public double Amount { get; set; }
        public string Unit { get; set; }
    }
}
