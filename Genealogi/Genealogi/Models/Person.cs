using System.ComponentModel.DataAnnotations;

namespace Genealogi.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DeathDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? DeathPlace { get; set; }
        public int? Mother { get; set; }
        public int? Father { get; set; }
        public Byte[]? Image { get; set; }
    }
}
