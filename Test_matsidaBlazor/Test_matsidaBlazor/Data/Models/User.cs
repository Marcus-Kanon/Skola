using System.ComponentModel.DataAnnotations;

namespace Test_matsidaBlazor.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<Inventory> Inventories { get; set; }
    }
}
