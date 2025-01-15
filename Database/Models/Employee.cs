
namespace GestorDeConsumo.Database.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public byte[] fingerprint { get; set; }

        public Employee(int id, string name, byte[] fingerprint)
        {
            this.id = id;
            this.name = name;
            this.fingerprint = fingerprint;
        }
    }
}
