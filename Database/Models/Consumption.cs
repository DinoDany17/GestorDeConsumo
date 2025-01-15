namespace GestorDeConsumo.Database.Models
{
    public class Consumption
    {
        public int id { get; set; }
        public int employee_id { get; set; }
        public int dish_type_id { get; set; }
        public DateTime date { get; set; }

        public Consumption(int id, int employee_id, int dish_type_id, string date) 
        {
            this.id = id;
            this.employee_id = employee_id;
            this.dish_type_id = dish_type_id;
            this.date = DateTime.Parse(date);
        }
    }
}
