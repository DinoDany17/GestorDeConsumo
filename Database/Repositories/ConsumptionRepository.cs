using System.Data.SQLite;
using GestorDeConsumo.Database.Models;

namespace GestorDeConsumo.Database.Repositories
{
    public static class ConsumptionRepository
    {
        public static Consumption[] GetAll()
        {
            DatabaseConnection database = new DatabaseConnection();
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
            return consumptions.ToArray();
        }

        public static Consumption[] GetAll(string condition)
        {
            DatabaseConnection database = new DatabaseConnection();
            List<Consumption> consumptions = new List<Consumption>();
            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string sql = $"SELECT * FROM consumption WHERE {condition}";
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
            return consumptions.ToArray();
        }

        public static Consumption? GetById(int id) 
        {
            DatabaseConnection database = new DatabaseConnection();
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

        public static ConsumptionReportRow[] GetConsumptionsForReport(string start, string end)
        {
            DatabaseConnection database = new DatabaseConnection();
            List<ConsumptionReportRow> reportRow = new List<ConsumptionReportRow>();
            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string sql = "SELECT DishType.name as dish, cost, COUNT(DishType.id) as quantity FROM Consumption INNER JOIN DishType ON (DishType.id = Consumption.dish_type_id) " +
                $"WHERE date BETWEEN '{start} 00:00:00' AND '{end} 23:59:59' GROUP BY DishType.id;";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal cost = reader.GetDecimal(reader.GetOrdinal("cost"));
                            int quantity = reader.GetInt32(reader.GetOrdinal("quantity"));
                            decimal total = cost * quantity;
                            reportRow.Add(new ConsumptionReportRow(
                                reader.GetString(reader.GetOrdinal("dish")),
                                cost,
                                quantity,
                                total
                            ));
                        }
                    }
                }
            }
            return reportRow.ToArray();
        }

        public static Consumption? Insert(int employee_id, int dish_type_id, string date)
        {
            try
            {
                DatabaseConnection database = new DatabaseConnection();
                using (SQLiteConnection connection = database.GetConnection())
                {
                    connection.Open();
                    string sql = "INSERT INTO consumption (employee_id, dish_type_id, date) VALUES (@employee_id, @dish_type_id, @date); SELECT LAST_INSERT_ROWID()";
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@employee_id", employee_id);
                        command.Parameters.AddWithValue("@dish_type_id", dish_type_id);
                        command.Parameters.AddWithValue("@date", date);
                        int id = Convert.ToInt32(command.ExecuteScalar());
                        return new Consumption(id, employee_id, dish_type_id, date);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar empleado: {ex.Message}");
                return null;
            }
        }

        public static bool Update(Consumption consumption)
        {
            DatabaseConnection database = new DatabaseConnection();
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

        public static bool Delete(int id)
        {
            DatabaseConnection database = new DatabaseConnection();
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
