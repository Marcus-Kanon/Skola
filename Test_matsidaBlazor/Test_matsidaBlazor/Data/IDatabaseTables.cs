using Microsoft.EntityFrameworkCore;
using Test_matsidaBlazor.Data.Models;

namespace Test_matsidaBlazor.Data
{
    public interface IDatabaseTables
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Nutrients> Nutrients { get; set; }
        public DbSet<Recipes_Ingredients> Recipes_Nutrients { get; set; }
    }
}
