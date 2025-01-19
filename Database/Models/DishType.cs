namespace GestorDeConsumo.Database.Models
{
    public class DishType
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal cost { get; set; }

        public string? deleted_at { get; set; }

        public DishType(int id, string name, decimal cost, string? deleted_at)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.deleted_at = deleted_at;
        }
    }
}
