using Microsoft.EntityFrameworkCore;
using Genealogi.Data;
using Genealogi.Models;

namespace Genealogi.Helpers
{
    public static class LoadPeople
    {
        public static void Load(PersonDbContext db)
        {
            List<Person> people = new();
            people.Add(new Person() { Name = "A", LastName = "A", BirthDate = new DateTime(1991,12, 04), DeathDate = DateTime.Now, BirthPlace = "A Place", DeathPlace = "A Place", Father = 1, Mother = 2, Image = null });

            foreach(var person in people)
            {
                if(!db.People.Any(p => p.Name == person.Name && p.LastName == person.LastName && p.BirthDate == person.BirthDate))
                    db.People.Add(person);
            }

            db.SaveChanges();
        }
    }
}
