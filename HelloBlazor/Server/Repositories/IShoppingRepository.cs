using HelloBlazor.Shared;

namespace HelloBlazor.Server.Repositories
{
    public interface IShoppingRepository
    {
        void AddItem(ShoppingItem item);
        void DeleteByName(string name);
        ShoppingItem[] GetAll();
    }
}