using HelloBlazor.Shared;

namespace HelloBlazor.Server.Repositories
{
    public interface IShoppingRepository
    {
        void AddItem(ShoppingItem item);
<<<<<<< Updated upstream
        ShoppingItem[] GetAll();
=======
        
        ShoppingItem[] GetAll();

        void DeleteById(int id);

        void UpdateItem(ShoppingItem item);
>>>>>>> Stashed changes
    }
}