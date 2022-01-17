namespace Test_matsidaBlazor.Data.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public ICollection<Inventories_Ingredients> Inventories_Ingredients { get; set; } = null!;
    }
}
