using Microsoft.EntityFrameworkCore;
using Test_matsidaBlazor.Data.Models;

namespace Test_matsidaBlazor.Data
{
    public class DataContext : DbContext
    {
        DbSet<Ingredient> Ingredients { get; set; }
        DbSet<Recipe> Recipes { get; set; }
        DbSet<Nutrients> Nutrients { get; set; }
        DbSet<Recipes_Ingredients> Recipes_Nutrients { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipes_Ingredients>()
                .HasOne(ri => ri.Ingredient)
                .WithMany(i => i.Recipes_Ingredients)
                .HasForeignKey(ri => ri.IngredientId);

            modelBuilder.Entity<Recipes_Ingredients>()
                .HasOne(ri => ri.Recipe)
                .WithMany(i => i.Recipes_Ingredients)
                .HasForeignKey(ri => ri.RecipeId);

            modelBuilder.Entity<Ingredient>()
                .HasOne(i => i.Nutrients)
                .WithOne(n => n.Ingredient);
        }
    }
}
