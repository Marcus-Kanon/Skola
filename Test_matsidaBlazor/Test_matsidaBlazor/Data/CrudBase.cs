using Microsoft.EntityFrameworkCore;
using Test_matsidaBlazor.Data.Models;

namespace Test_matsidaBlazor.Data
{
    /*
    internal class CrudBase<T, TDbSets> : IDatabaseTables
        where T : DataContext
        where TDbSets : IDatabaseTables
    {
        static T _context;
        static List<IEnumerable<object>> _lists = new();

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Nutrients> Nutrients { get; set; }
        public DbSet<Recipes_Ingredients> Recipes_Nutrients { get; set; }

        public CrudBase(T context)
        {
            _context = context;
            UpdateLists();
        }

        public void UpdateLists()
       
            
            var properties = _context.GetType().GetProperties();
            foreach (var property in properties)
            {
                var propType = property.PropertyType;
                var isDbSet = propType.IsGenericType && (typeof(DbSet<>).IsAssignableFrom(propType.GetGenericTypeDefinition()));

                if (isDbSet)
                {
                    var q = (IQueryable)property.GetValue(_context);
                    var set = _context.Set();

                    _lists.Add(_context.Model.GetEntityTypes().Take(1));
                }
            } 
            //TDbSets sets = Activator.CreateInstance(TDbSets);
            //var props = sets.GetType().GetProperties();
            //_lists.Add();
            
        }

        public void LoadContext()
        {

        }
    }
    */
}
