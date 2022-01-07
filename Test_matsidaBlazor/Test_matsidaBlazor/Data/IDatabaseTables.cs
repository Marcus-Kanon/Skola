using Microsoft.EntityFrameworkCore;
using Test_matsidaBlazor.Data.Models;

namespace Test_matsidaBlazor.Data
{
    public interface IDatabaseTables
    {
        public DbSet<Ingredient> Ingredients { get; }
        public DbSet<Recipe> Recipes { get; }
        public DbSet<Nutrients> Nutrients { get; }
        public DbSet<Recipes_Ingredients> Recipes_Nutrients { get; }
    }
}
