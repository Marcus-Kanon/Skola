namespace Test_matsidaBlazor.Data.Models
{
    public class ShoppingList
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public ICollection<ShoppingLists_Ingredients> ShoppingLists_Ingredients { get; set; } = null!;
    }
}
