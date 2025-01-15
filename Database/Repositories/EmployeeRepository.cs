using GestorDeConsumo.Database.Models;
using System.Data.SQLite;

namespace GestorDeConsumo.Database.Repositories
{
    public class EmployeeRepository
    {
        private DatabaseConnection database;
        EmployeeRepository()
        {
            this.database = new DatabaseConnection();

        }

        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Employee";

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
                                reader.GetFieldValue<byte[]>(reader.GetOrdinal("fingerprint"))
                            );
                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }

        public Employee? GetById(int id)
        {
            Employee? employee = null;

            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Employee WHERE id = @id";

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
                                reader.GetFieldValue<byte[]>(reader.GetOrdinal("fingerprint"))
                            );
                        }
                    }
                }
            }

            return employee;
        }

        public Employee Insert(Employee employee)
        {
            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Employee (name, fingerprint) VALUES (@name, @fingerprint); SELECT SCOPE_IDENTITY();";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", employee.name);
                    command.Parameters.AddWithValue("@fingerprint", employee.fingerprint);
                    employee.id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return employee;
        }

        public bool Update(Employee employee)
        {
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

        public bool Delete(int id)
        {
            bool success = false;
            using (SQLiteConnection connection = database.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Employee WHERE id = @id";
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
