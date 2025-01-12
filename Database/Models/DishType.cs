namespace GestorDeConsumo.Database.Models
{
    internal class DishType : CRUD
    {
        static string tableName = "DishType";
        static string[] columns = new string[] { "name", "cost" };
        public DishType() : base(tableName, columns)
        {
        }
    }
}
