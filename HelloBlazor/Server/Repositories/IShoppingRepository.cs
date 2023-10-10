using HelloBlazor.Shared;

namespace HelloBlazor.Server.Repositories
{
    public interface IShoppingRepository
    {
        void AddItem(ShoppingItem item);
        ShoppingItem[] GetAll();
    }
}