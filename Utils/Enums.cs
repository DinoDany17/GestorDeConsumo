using GestorDeConsumo.Database.Models;

namespace GestorDeConsumo.Utils
{
    internal static class Enums
    {
        public static DishType[] dishTypes = new DishType[0];

        public static void UpdateDishType(DishType[] types)
        {
            dishTypes = types;
        }

        public static int GetDishTypeIdByName(string name)
        {
            foreach (DishType type in dishTypes)
            {
                if (type.name == name)
                {
                    return type.id;
                }
            }
            return -1;
        }
    }
}
