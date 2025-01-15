using System.Data.SQLite;

namespace GestorDeConsumo
{
    public class DatabaseConnection
    {
        private static string directorio = Environment.GetEnvironmentVariable("APP_DIRECTORY") ?? "";
        private static string databaseLocation = Path.Combine(directorio, "Database", "master.db");
        private static string connectionString = $"Data Source={databaseLocation};Version=3;";

        public string GetDatabaseLocation()
        {
            return databaseLocation;
        }

        public void CreateDatabase()
        {
            try
            {
                SQLiteConnection.CreateFile(databaseLocation);
                using (SQLiteConnection connection = GetConnection())
                {
                    connection.Open();
                    string sql = "CREATE TABLE IF NOT EXISTS Employee (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT NOT NULL, fingerprint BLOB NOT NULL)";
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    sql = "CREATE TABLE IF NOT EXISTS DishType (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT NOT NULL, cost REAL NOT NULL)";
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    sql = "CREATE TABLE IF NOT EXISTS Consumption (id INTEGER PRIMARY KEY AUTOINCREMENT, employee_id INTEGER NOT NULL, dish_type_id INTEGER NOT NULL, date TEXT NOT NULL, FOREIGN KEY(employee_id) REFERENCES Employee(id), FOREIGN KEY(dish_type_id) REFERENCES DishType(id))";
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    sql = "INSERT INTO DishType (name, cost) VALUES ('Platillo regular', 0), ('Platillo especial', 0), ('Combo', 0)";
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear la base de datos: {ex.Message}");
            }
        }


        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
