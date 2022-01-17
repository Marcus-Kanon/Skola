namespace Test_matsidaBlazor.Data.Models
{
    public class Inventories_Ingredients
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public int IngredientId { get; set; }
        public Inventory Inventory { get; set; } = new();
        public Ingredient Ingredient { get; set; } = new();
        public double Amount { get; set; }
        public string Unit { get; set; } = "";
    }
}
