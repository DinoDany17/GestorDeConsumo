namespace GestorDeConsumo.Database.Models
{
    internal class Consumption : CRUD
    {
        static string tableName = "DishType";
        static string[] columns = new string[] { "employee_id", "dish_type_id", "date" };
        public Consumption() : base(tableName, columns)
        {
        }
    }
}
