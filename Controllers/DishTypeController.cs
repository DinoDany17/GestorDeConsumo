using GestorDeConsumo.Database.Models;
using GestorDeConsumo.Database.Repositories;

namespace GestorDeConsumo.Controllers
{
    public static class DishTypeController
    {
        public static void UpdateDishTypesEnum()
        {
            Enums.UpdateDishType(DishTypeRepository.GetAll());
        }

        public static DishType[] GetAllDishTypes()
        {
            return DishTypeRepository.GetAll();
        }

        public static DishType? RegisterDishType(string dishname, decimal cost)
        {
            DishType? newDish = DishTypeRepository.Insert(dishname, cost);
            UpdateDishTypesEnum();
            return newDish;
        }

        public static bool DeleteDishType(int id)
        {
            return DishTypeRepository.Delete(id);
        }
    }
}
