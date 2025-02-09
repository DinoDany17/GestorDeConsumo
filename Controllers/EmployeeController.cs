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

        public static Employee? RegisterEmployee(int emp_number, string name, byte[] fingerprint)
        {
            return EmployeeRepository.Insert(emp_number, name, fingerprint);
        }

        public static bool UpdateEmployee(int id, string columnName, dynamic value)
        {
            return EmployeeRepository.Update(id, columnName, value);
        }

        public static bool DeleteEmployee(int id)
        {
            return EmployeeRepository.Delete(id);
        }
    }
}
