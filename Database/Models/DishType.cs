namespace GestorDeConsumo.Database.Models
{
    public class DishType
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal cost { get; set; }

        public DishType(int id, string name, decimal cost)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
        }
    }
}
