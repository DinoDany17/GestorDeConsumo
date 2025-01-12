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
            SQLiteConnection.CreateFile(databaseLocation);
        }

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
