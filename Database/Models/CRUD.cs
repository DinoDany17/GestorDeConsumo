using System.Data.SQLite;

namespace GestorDeConsumo.Database.Models
{
    internal class CRUD
    {
        private string tableName;
        private string[] columns;
        public CRUD (string tableName, string[] columns)
        {
            this.tableName = tableName;
            this.columns = columns;
        }

        public void GetOneRow(string condition)
        {
            try
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                using (SQLiteConnection _connection = databaseConnection.GetConnection())
                {
                    _connection.Open();
                    string sql = $"SELECT * FROM {tableName} WHERE {condition}";
                    using (SQLiteCommand command = new SQLiteCommand(sql, _connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.WriteLine($"{reader.GetName(i)}: {reader.GetValue(i)}");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el empleado: {ex.Message}");
            }
        }

        public void GetAllRows(string condition = "")
        {
            try
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                using (SQLiteConnection _connection = databaseConnection.GetConnection())
                {
                    _connection.Open();
                    string sql = $"SELECT * FROM {tableName}{((condition != "") ? $"WHERE {condition}" : "")}";
                    using (SQLiteCommand command = new SQLiteCommand(sql, _connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.WriteLine($"{reader.GetName(i)}: {reader.GetValue(i)}");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los empleados: {ex.Message}");
            }
        }



        public void CreateRow(Dictionary<String, dynamic> values)
        {
            string columnsString = String.Join(", ", columns);
            string columnsValues = String.Join(", ", columns.Select(column => $"@{column}"));
            try
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                using (SQLiteConnection _connection = databaseConnection.GetConnection())
                {
                    _connection.Open();
                    string sql = $"INSERT INTO {tableName} ({columnsString}) VALUES ({columnsValues})";
                    using (SQLiteCommand command = new SQLiteCommand(sql, _connection))
                    {
                        foreach (string column in columns)
                        {
                            command.Parameters.AddWithValue($"@{column}", values[column]);
                        }
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar el empleado: {ex.Message}");
            }
        }

        public void UpdateRow(Dictionary<String, dynamic> values, string condition)
        {
            string columnsString = String.Join(", ", values.Select(value => $"{value.Key} = @{value.Key}"));
            try
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                using (SQLiteConnection _connection = databaseConnection.GetConnection())
                {
                    _connection.Open();
                    string sql = $"UPDATE {tableName} SET {columnsString} WHERE {condition}";
                    using (SQLiteCommand command = new SQLiteCommand(sql, _connection))
                    {
                        foreach (KeyValuePair<string, dynamic> value in values)
                        {
                            command.Parameters.AddWithValue($"@{value.Key}", value.Value);
                        }
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el empleado: {ex.Message}");
            }
        }
    }
}
