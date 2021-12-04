using Genealogi.Models;
using Microsoft.EntityFrameworkCore;

namespace Genealogi.Data
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
