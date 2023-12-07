using HelloBlazor.Shared;

namespace HelloBlazor.Server.Repositories
{
    public interface IShoppingRepository
    {
        //Tildeler item en unik id og tilføjer den.
        void AddItem(ShoppingItem item);

        // Fjerner item, hvor item.Id = id. Hvis den ikke
        // findes sker ingenting
        void DeleteById(int id);

        ShoppingItem[] GetAll();

        // returnerer alle items med Shop = shop.
        ShoppingItem[] GetAllByShop(string shop);

        // Opdaterer element med Id = item.Id.
        void UpdateItem(ShoppingItem item);
    }
}