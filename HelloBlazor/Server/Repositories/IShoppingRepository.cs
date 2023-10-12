using HelloBlazor.Shared;

namespace HelloBlazor.Server.Repositories
{
    public interface IShoppingRepository
    {
        void AddItem(ShoppingItem item);
        void DeleteById(int id);
        ShoppingItem[] GetAll();
        void UpdateItem(ShoppingItem item);
    }
}