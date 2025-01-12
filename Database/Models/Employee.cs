namespace GestorDeConsumo.Database.Models
{
    internal class Employee : CRUD
    {
        static string tableName = "Employee";
        static string[] columns = new string[] { "name", "fingerprint" };
        public Employee() : base(tableName, columns)
        {
        }
    }
}
