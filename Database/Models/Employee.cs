
namespace GestorDeConsumo.Database.Models
{
    public class Employee
    {
        public int id { get; set; }
        public int emp_number { get; set; }
        public string name { get; set; }
        public byte[] fingerprint { get; set; }

        public string? deleted_at { get; set; }

        public Employee(int id, int emp_number, string name, byte[] fingerprint, string? deleted_at)
        {
            this.id = id;
            this.emp_number = emp_number;
            this.name = name;
            this.fingerprint = fingerprint;
            this.deleted_at = deleted_at;
        }
    }
}
