using Microsoft.EntityFrameworkCore;
using Genealogi.Data;
using Genealogi.Models;

namespace Genealogi.Helpers
{
    public static class LoadPeople
    {
        public static void Load(GenealogiDbContext db)
        {
            List<Person> people = new();
            people.Add(new Person() { Name = "Farsa", LastName = "A", BirthDate = new DateTime(1991,12, 04), DeathDate = DateTime.Now, BirthPlace = "A Place", DeathPlace = "A Place", Father = null, Mother = null, Image = null });
            people.Add(new Person() { Name = "Morsa", LastName = "A", BirthDate = new DateTime(1983, 12, 04), DeathDate = DateTime.Now, BirthPlace = "A Place", DeathPlace = "A Place", Father = null, Mother = null, Image = null });
            people.Add(new Person() { Name = "Son", LastName = "A", BirthDate = new DateTime(2002, 12, 04), DeathDate = DateTime.Now, BirthPlace = "A Place", DeathPlace = "A Place", FatherId = 1, MotherId = 2, Image = null });

            foreach (var person in people)
            {
                if(!db.People.Any(p => p.Name == person.Name && p.LastName == person.LastName && p.BirthDate == person.BirthDate))
                    db.People.Add(person);
            }

            db.SaveChanges();
        }
    }
}
