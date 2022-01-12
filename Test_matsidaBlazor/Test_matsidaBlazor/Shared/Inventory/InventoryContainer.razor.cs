using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Test_matsidaBlazor.Data.Models;

namespace Test_matsidaBlazor.Shared.Inventory
{
    public partial class InventoryContainer : ComponentBase
    {
        public ObservableCollection<Ingredient> Items;
        public bool ItemsInitialized { get; set; } = false;

        public InventoryContainer()
        {
            Items = new();
            Items.CollectionChanged += OnListChange;
        }

        protected void OnListChange(object? sender, NotifyCollectionChangedEventArgs e)
        {
            if(e.OldItems != null)
            {
                foreach (Ingredient oldItem in e.OldItems)
                {
                    Console.WriteLine("removing; " + oldItem.Name + " Id: " + oldItem.Id + " from db");
                    crud.RemoveInventoryItem(Tracker, oldItem, InventoryId);
                }
            }

            if (e.NewItems != null)
            {
                foreach (Ingredient newItem in e.NewItems)
                {
                    Console.WriteLine("EVENT NEW ITEM: " + newItem.Name);

                    if(crud.CheckValidIngredient(newItem))
                    {
                        Console.WriteLine("adding; " + newItem.Name + " Id: " + newItem.Id + " to db");
                        var number = Items.Where(p => p.Id == newItem.Id).ToList().Count();
                        if (number > 1 && ItemsInitialized)
                        {
                            Message = "Ingrediens finns redan i listan";
                            Console.WriteLine("Ingrediens finns redan i listan");

                            Items.Remove(newItem);
                        }

                        crud.AddInventoryItem(Tracker, newItem, InventoryPage);
                    }
                    else
                    {
                        Console.WriteLine(newItem.Name + " is not valid to add");
                    }
                }
            }
        }
    }
}
