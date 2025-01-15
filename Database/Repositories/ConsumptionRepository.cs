using System.Data.SQLite;
using GestorDeConsumo.Database.Models;

namespace GestorDeConsumo.Database.Repositories
{
    public class ConsumptionRepository
    {
        private DatabaseConnection database;
        public ConsumptionRepository() 
        {
            this.database = new DatabaseConnection();
        }

        public List<Consumption> GetAll()
        {
            List<Consumption> consumptions = new List<Consumption>();
            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM consumption";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            consumptions.Add(new Consumption(
                                reader.GetInt32(reader.GetOrdinal("id")),
                                reader.GetInt32(reader.GetOrdinal("employee_id")),
                                reader.GetInt32(reader.GetOrdinal("dish_type_id")),
                                reader.GetString(reader.GetOrdinal("date"))
                            ));
                        }
                    }
                }
            }
            return consumptions;
        }

        public Consumption? GetById(int id) 
        {
            Consumption? consumption = null;
            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM consumption WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            consumption = new Consumption(
                                reader.GetInt32(reader.GetOrdinal("id")),
                                reader.GetInt32(reader.GetOrdinal("employee_id")),
                                reader.GetInt32(reader.GetOrdinal("dish_type_id")),
                                reader.GetString(reader.GetOrdinal("date"))
                            );
                        }
                    }
                }
            }
            return consumption;
        }

        public Consumption Insert(Consumption consumption)
        {
            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string sql = "INSERT INTO consumption (employee_id, dish_type_id, date) VALUES (@employee_id, @dish_type_id, @date)";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@employee_id", consumption.employee_id);
                    command.Parameters.AddWithValue("@dish_type_id", consumption.dish_type_id);
                    command.Parameters.AddWithValue("@date", consumption.date);
                    consumption.id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return consumption;
        }

        public bool Update(Consumption consumption)
        {
            bool success = false;
            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string sql = "UPDATE consumption SET employee_id = @employee_id, dish_type_id = @dish_type_id, date = @date WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@employee_id", consumption.employee_id);
                    command.Parameters.AddWithValue("@dish_type_id", consumption.dish_type_id);
                    command.Parameters.AddWithValue("@date", consumption.date);
                    command.Parameters.AddWithValue("@id", consumption.id);
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
                string sql = "DELETE FROM consumption WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    success = command.ExecuteNonQuery() > 0;
                }
            }
            return success;
        }
    }
}
