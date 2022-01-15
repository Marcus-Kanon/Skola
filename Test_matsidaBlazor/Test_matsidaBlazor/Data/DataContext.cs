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
        public DbSet<Inventories_Ingredients> Inventories_Ingredients { get; set; }
        public DbSet<Inventories_Ingredients> ShoppingLists_Ingredients { get; set; }


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

            modelBuilder.Entity<User>()
                .HasMany(u => u.ShoppingLists)
                .WithOne(i => i.User);
            modelBuilder.Entity<ShoppingList>()
                .HasOne(i => i.User)
                .WithMany(u => u.ShoppingLists);

            modelBuilder.Entity<Inventories_Ingredients>()
                .HasOne(ii => ii.Inventory)
                .WithMany(inv => inv.Inventories_Ingredients)
                .HasForeignKey(ii => ii.InventoryId)
                .OnDelete(DeleteBehavior.Cascade);
                
            modelBuilder.Entity<Inventories_Ingredients>()
                .HasOne(ii => ii.Ingredient)
                .WithMany(inv => inv.Inventories_Ingredients)
                .HasForeignKey(ii => ii.IngredientId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ShoppingLists_Ingredients>()
                .HasOne(ii => ii.ShoppingList)
                .WithMany(inv => inv.Inventories_Ingredients)
                .HasForeignKey(ii => ii.InventoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ShoppingLists_Ingredients>()
                .HasOne(ii => ii.Ingredient)
                .WithMany(inv => inv.ShoppingLists_Ingredients)
                .HasForeignKey(ii => ii.IngredientId)
                .OnDelete(DeleteBehavior.Cascade);

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
