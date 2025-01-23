using System.Data.SQLite;
using GestorDeConsumo.Database.Models;

namespace GestorDeConsumo.Database.Repositories
{
    public static class DishTypeRepository
    {

        public static DishType[] GetAll()
        {
            DatabaseConnection database = new DatabaseConnection();
            List<DishType> dishTypes = new List<DishType>();

            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM DishType WHERE deleted_at IS NULL";

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
                                reader.GetDecimal(reader.GetOrdinal("cost")),
                                null
                            );
                            dishTypes.Add(dishType);
                        }
                    }
                }
            }

            return dishTypes.ToArray();
        }

        public static DishType? GetById(int id)
        {
            DatabaseConnection database = new DatabaseConnection();
            DishType? dishType = null;

            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM DishType WHERE id = @id AND deleted_at IS NULL";

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
                                reader.GetDecimal(reader.GetOrdinal("cost")),
                                null
                            );
                        }
                    }
                }
            }

            return dishType;
        }

        public static DishType? GetByName(string name)
        {
            DishType? dishType = null;
            try
            {
                DatabaseConnection database = new DatabaseConnection();
                using (SQLiteConnection connection = database.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM DishType WHERE name = @name AND deleted_at IS NULL";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dishType = new DishType
                                (
                                    reader.GetInt32(reader.GetOrdinal("id")),
                                    reader.GetString(reader.GetOrdinal("name")),
                                    reader.GetDecimal(reader.GetOrdinal("cost")),
                                    null
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el platillo por nombre: {ex.Message}");
            }
            return dishType;
        }

        public static DishType? Insert(string name, decimal cost)
        {
            try
            {
                DatabaseConnection database = new DatabaseConnection();
                using (SQLiteConnection connection = database.GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO DishType (name, cost) VALUES (@name, @cost); SELECT LAST_INSERT_ROWID();";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@cost", cost);
                        int id = Convert.ToInt32(command.ExecuteScalar());
                        return new DishType(id, name, cost, null);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar empleado: {ex.Message}");
                return null;
            }
        }

        public static bool Update(int id, string columnName, dynamic value)
        {
            DatabaseConnection database = new DatabaseConnection();
            bool success = false;
            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string query = $"UPDATE DishType SET {columnName} = @value WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@value", value);
                    success = command.ExecuteNonQuery() > 0;
                }

            }
            return success;
        }

        public static bool Delete(int id)
        {
            DatabaseConnection database = new DatabaseConnection();
            bool success = false;
            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string query = "UPDATE DishType SET deleted_at = @deleted_at WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@deleted_at", currentDateTime);
                    success = command.ExecuteNonQuery() > 0;
                }
            }
            return success;
        }
    }
}
