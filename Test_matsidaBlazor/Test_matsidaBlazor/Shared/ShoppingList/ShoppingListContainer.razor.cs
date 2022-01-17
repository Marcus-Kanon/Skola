using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Test_matsidaBlazor.Data.Models;

namespace Test_matsidaBlazor.Shared.ShoppingList
{
    public partial class ShoppingListContainer : ComponentBase
    {
        public ObservableCollection<Ingredient> Items;
        public bool ItemsInitialized { get; set; } = false;

        public ShoppingListContainer()
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
                    crud.RemoveShoppingListItem(Tracker, oldItem, Page);
                }
            }

            if (e.NewItems != null)
            {
                foreach (Ingredient newItem in e.NewItems)
                {
                    if(crud.CheckValidIngredient(newItem))
                    {
                        var number = Items.Where(p => p.Id == newItem.Id).ToList().Count;

                        if (number > 1 && ItemsInitialized)
                        {
                            Message = "Ingrediens finns redan i listan";

                            Items.Remove(newItem);
                        }

                        crud.AddShoppingListItem(Tracker, newItem, Page);
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
