using System;
using HelloBlazor.Shared;
using Microsoft.Data.Sqlite;

namespace HelloBlazor.Server.Repositories
{
    public class LoginRepositorySQLite :ILoginRepository
    {
        private const string connectionString = @"Data Source=Data/shopping.db";


        

        

        public BEUser[] GetUsers(string email)
        {
            var result = new List<BEUser>();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $"SELECT * FROM User where email = $email";
                command.Parameters.AddWithValue("$email", email);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var _email = reader.GetString(1);
                        var pwd = reader.GetString(2);
                        var role = reader.GetInt32(3);

                        var user = new BEUser
                        {
                            Id = id,
                            Email = _email,
                            Password = pwd,
                            IsCoordinator = (role == 1)
                        };
                        result.Add(user);
                    }
                }
            }
            return result.ToArray();
        }

        public bool Verify(string email, string password)
        {
            var users = GetUsers(email);
            return users.Length == 1 && users[0].Password.Equals(password);
        }
    }
}

