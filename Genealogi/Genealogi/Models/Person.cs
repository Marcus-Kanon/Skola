using System.ComponentModel.DataAnnotations;

namespace Genealogi.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string DeathDate { get; set; }
        public string BirthPlace { get; set; }
        public string DeathPlace { get; set; }
        public int Mother { get; set; }
        public int Father { get; set; }
    }
}
