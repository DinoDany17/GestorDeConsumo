using GestorDeConsumo.Database.Models;
using System.Data.SQLite;

namespace GestorDeConsumo.Database.Repositories
{
    public static class EmployeeRepository
    {

        public static Employee[] GetAll()
        {
            DatabaseConnection database = new DatabaseConnection();
            List<Employee> employees = new List<Employee>();

            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Employee WHERE deleted_at IS NULL";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee
                            (
                                reader.GetInt32(reader.GetOrdinal("id")),
                                reader.GetString(reader.GetOrdinal("name")),
                                reader.GetFieldValue<byte[]>(reader.GetOrdinal("fingerprint")),
                                null
                            );
                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees.ToArray();
        }

        public static Employee? GetById(int id)
        {
            DatabaseConnection database = new DatabaseConnection();
            Employee? employee = null;

            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Employee WHERE id = @id AND deleted_at IS NULL";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new Employee
                            (
                                reader.GetInt32(reader.GetOrdinal("id")),
                                reader.GetString(reader.GetOrdinal("name")),
                                reader.GetFieldValue<byte[]>(reader.GetOrdinal("fingerprint")),
                                null
                            );
                        }
                    }
                }
            }

            return employee;
        }

        public static Employee? Insert(string name, byte[] fingerprint)
        {
            try
            {
                DatabaseConnection database = new DatabaseConnection();
                using (SQLiteConnection connection = database.GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Employee (name, fingerprint) VALUES (@name, @fingerprint); SELECT LAST_INSERT_ROWID()";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@fingerprint", fingerprint);
                        int id = Convert.ToInt32(command.ExecuteScalar());
                        return new Employee(id, name, fingerprint, null);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar empleado: {ex.Message}");
                return null;
            }
        }

        public static bool Update(Employee employee)
        {
            DatabaseConnection database = new DatabaseConnection();
            bool success = false;
            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Employee SET name = @name, fingerprint = @fingerprint WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", employee.id);
                    command.Parameters.AddWithValue("@name", employee.name);
                    command.Parameters.AddWithValue("@fingerprint", employee.fingerprint);
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
                string currentDatetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string query = "UPDATE Employee SET deleted_at = @deleted_at WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@deleted_at", currentDatetime);
                    success = command.ExecuteNonQuery() > 0;
                }
            }
            return success;
        }
    }
}
