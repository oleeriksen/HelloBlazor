using System;
using HelloBlazor.Shared;

namespace HelloBlazor.Server.Repositories
{
    public class ShoppingRepositoryInMemory
    {
        private List<ShoppingItem> mProducts = new() {
                  new ShoppingItem { Name = "bananer", Id = 1, Price = 12, Done = true },
                  new ShoppingItem { Name = "Æbler", Id = 2, Price = 14, Done = false  }
        };
        
        public void AddItem(ShoppingItem item)
        {
            mProducts.Add(item);
        }

        public ShoppingItem[] GetAll()
        {
            return mProducts.ToArray();
        }
    }
}

