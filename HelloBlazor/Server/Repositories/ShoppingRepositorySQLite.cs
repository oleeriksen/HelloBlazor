using System;
using HelloBlazor.Shared;
using Microsoft.Data.Sqlite;

namespace HelloBlazor.Server.Repositories
{
	public class ShoppingRepositorySQLite : IShoppingRepository
	{
        private const string connectionString = @"Data Source=//Users/ole/Data/shopping.db";
        public ShoppingRepositorySQLite()
		{
		}

        public void AddItem(ShoppingItem item)
        {
           
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public ShoppingItem[] GetAll()
        {
            var result = new List<ShoppingItem>();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"SELECT * FROM shoppingitem";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        var price = reader.GetDecimal(2);
                        var amount = reader.GetInt32(3);
                        var description = reader.GetString(4);
                        var done = reader.GetInt32(5) == 0 ? false: true ;
                        var shop = reader.GetString(6);

                        var si = new ShoppingItem { Id = id, Name = name,
                                                    Price = price, Amount = amount,
                                                    Description = description,
                                                    Done = done, Shop = shop };
                        result.Add(si);
                    }
                }
            }
            return result.ToArray();
        }

        public void UpdateItem(ShoppingItem item)
        {
            throw new NotImplementedException();
        }
    }
}

