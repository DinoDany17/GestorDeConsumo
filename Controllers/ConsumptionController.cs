using GestorDeConsumo.Database.Models;
using GestorDeConsumo.Database.Repositories;

namespace GestorDeConsumo.Controllers
{
    public static class ConsumptionController
    {
        public static (int, string, string, string)? RegisterConsumption(string dishName)
        {
            DateTime dateTime = DateTime.Now;
            string timeStamp = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string hour = dateTime.ToString("HH:mm:ss");
            DishType? dish = DishTypeRepository.GetByName(dishName);
            if (dish != null)
            {
                Consumption? newConsumption = ConsumptionRepository.Insert(1, dish.id, timeStamp);
                if (newConsumption != null)
                {
                    Employee? employee = EmployeeRepository.GetById(newConsumption.employee_id);
                    if (employee != null)
                    {
                        return (newConsumption.id, hour, employee.name, dish.name);
                    }
                }
            }
            return null;
        }

        public static Consumption[] GetAllConsumptions()
        {
            return ConsumptionRepository.GetAll();
        }

        public static (int, string, string, string)[] GetConsumptionsForTable()
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            Consumption[] consumptions = ConsumptionRepository.GetAll($"date LIKE ('{today}%')");
            List<(int, string, string, string)> formattedConsumption = new List<(int, string, string, string)>();
            for (int i = 0; i < consumptions.Length; i++)
            {
                Employee? employee = EmployeeRepository.GetById(consumptions[i].employee_id);
                DishType? dishType = DishTypeRepository.GetById(consumptions[i].dish_type_id);
                if (employee != null && dishType != null)
                {
                    formattedConsumption.Add((consumptions[i].id, consumptions[i].date.ToString("HH:mm:ss"), employee.name, dishType.name));
                }
            }
            return formattedConsumption.ToArray();
        }

        public static bool DeleteConsumption(int id)
        {
            return ConsumptionRepository.Delete(id);
        }
    }
}
