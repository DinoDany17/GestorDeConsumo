
namespace GestorDeConsumo.Database.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public byte[] fingerprint { get; set; }

        public string? deleted_at { get; set; }

        public Employee(int id, string name, byte[] fingerprint, string? deleted_at)
        {
            this.id = id;
            this.name = name;
            this.fingerprint = fingerprint;
            this.deleted_at = deleted_at;
        }
    }
}
