namespace Test_matsidaBlazor.Data.Models
{
    public class ShoppingLists_Ingredients
    {
        public int Id { get; set; }
        public int ShoppingListId { get; set; }
        public int IngredientId { get; set; }
        public ShoppingList ShoppingList { get; set; } = new();
        public Ingredient Ingredient { get; set; } = new();
        public double Amount { get; set; }
        public string Unit { get; set; } = "";
    }
}
