using System.Text.RegularExpressions;

namespace GestorDeConsumo.Utils
{
    public static class Validations
    {
        public static bool validateDecimal(string val)
        {
            return Regex.IsMatch(val, @"^\d+(\.\d+)?$");
        }
    }
}
