using System.Data;

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

    public class ConsumptionTableRow
    {
        public int id { get; set; }
        public string hour { get; set; }
        public string employee { get; set; }
        public string dish { get; set; }

        public ConsumptionTableRow(int id, string hour, string employee, string dish)
        {
            this.id = id;
            this.hour = hour;
            this.employee = employee;
            this.dish = dish;
        }
    }

    public class ConsumptionReportRow
    {
        public string dish { get; set; }
        public decimal cost { get; set; }
        public int quantity { get; set; }
        public decimal total { get; set; }

        public ConsumptionReportRow(string dish, decimal cost, int quantity, decimal total)
        {
            this.dish = dish;
            this.cost = cost;
            this.quantity = quantity;
            this.total = total;
        }
    }
}