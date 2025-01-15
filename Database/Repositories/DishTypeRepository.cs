using System.Data.SQLite;
using GestorDeConsumo.Database.Models;

namespace GestorDeConsumo.Database.Repositories
{
    public class DishTypeRepository
    {
        private DatabaseConnection database;

        public DishTypeRepository()
        {

            this.database = new DatabaseConnection();
        }

        public List<DishType> GetAll()
        {
            List<DishType> dishTypes = new List<DishType>();

            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM DishType";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DishType dishType = new DishType
                            (
                                reader.GetInt32(reader.GetOrdinal("id")),
                                reader.GetString(reader.GetOrdinal("name")),
                                reader.GetDecimal(reader.GetOrdinal("cost"))
                            );
                            dishTypes.Add(dishType);
                        }
                    }
                }
            }

            return dishTypes;
        }

        public DishType? GetById(int id)
        {
            DishType? dishType = null;

            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM DishType WHERE id = @id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dishType = new DishType
                            (
                                reader.GetInt32(reader.GetOrdinal("id")),
                                reader.GetString(reader.GetOrdinal("name")),
                                reader.GetDecimal(reader.GetOrdinal("cost"))
                            );
                        }
                    }
                }
            }

            return dishType;
        }

        public DishType Insert(DishType dishType)
        {
            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO DishType (name, cost) VALUES (@name, @cost); SELECT SCOPE_IDENTITY();";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", dishType.name);
                    command.Parameters.AddWithValue("@cost", dishType.cost);
                    dishType.id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return dishType;
        }

        public bool Update(DishType dishType)
        {
            bool success = false;
            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string query = "UPDATE DishType SET name = @name, cost = @cost WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", dishType.id);
                    command.Parameters.AddWithValue("@name", dishType.name);
                    command.Parameters.AddWithValue("@cost", dishType.cost);
                    success = command.ExecuteNonQuery() > 0;
                }

            }
            return success;
        }

        public bool Delete(int id)
        {
            bool success = false;
            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM DishType WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    success = command.ExecuteNonQuery() > 0;
                }
            }
            return success;
        }
    }
}
