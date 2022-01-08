using Microsoft.EntityFrameworkCore;
using Test_matsidaBlazor.Data.Models;

namespace Test_matsidaBlazor.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; } = null!;
        public DbSet<Recipe> Recipes { get; set; } = null!;
        public DbSet<Nutrients> Nutrients { get; set; } = null!;
        public DbSet<Inventory> Inventories { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Recipes_Ingredients> Recipes_Inredients { get; set; } = null!;
        public DbSet<LoginTracker> LoginTrackers { get; set; } = null!;


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DataContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //https://stackoverflow.com/a/59306299/16859995
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Inventories)
                .WithOne(i => i.User);
            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.User)
                .WithMany(u => u.Inventories);
            modelBuilder.Entity<Inventory>()
                .HasMany(inv => inv.Ingredients)
                .WithMany(ing => ing.Inventories);
            modelBuilder.Entity<Ingredient>()
                .HasMany(ing => ing.Inventories)
                .WithMany(inv => inv.Ingredients);

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
