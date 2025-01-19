using GestorDeConsumo.Database.Repositories;
using GestorDeConsumo.Database.Models;

namespace GestorDeConsumo.Controllers
{
    public static class EmployeeController
    {
        public static Employee[] GetAllEmployees()
        {
            return EmployeeRepository.GetAll();
        }

        public static Employee? RegisterEmployee(string name, byte[] fingerprint)
        {
            return EmployeeRepository.Insert(name, fingerprint);
        }

        public static bool DeleteEmployee(int id)
        {
            return EmployeeRepository.Delete(id);
        }
    }
}
