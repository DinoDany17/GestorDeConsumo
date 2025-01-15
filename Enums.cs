namespace GestorDeConsumo
{
    internal static class Enums
    {
        public static Dictionary<string, float> DishTypes;

        public static void UpdateDishType((string, float)[] types)
        {
            DishTypes = new Dictionary<string, float>();
            foreach ((string type, float cost) in types)
            {
                DishTypes.Add(type, cost);
            }
        }
    }
}
