using System;
using HelloBlazor.Shared;

namespace HelloBlazor.Server.Repositories
{
    public class ShoppingRepositoryInMemory : IShoppingRepository
    {
        private List<ShoppingItem> mProducts = new() {
                  new ShoppingItem { Name = "bananer", Price = 12, Done = true },
                  new ShoppingItem { Name = "Æbler", Price = 14, Done = false  }
        };

        public void AddItem(ShoppingItem item){
            mProducts.Add(item);
        }

        public void DeleteByName(string name)
        {
            mProducts.RemoveAll((item) => item.Name.Equals(name));
        }

        public ShoppingItem[] GetAll() => mProducts.ToArray();
  
    }
}

