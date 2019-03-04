using Learn.CSharp7.Common.Models;

namespace Learn.CSharp7.Common.Utilis
{
    public static class ExtensionMethods
    {

        public static (int value, bool parsed) ParseToInteger(this string input)
        {
            var returnValue = (value: 0, parsed: false);

            returnValue.parsed = int.TryParse(input, out returnValue.value);

            return returnValue;
        }

        public static void Deconstruct(this Manager manager, out string id, out string name)
        {
            id = manager.Id;
            name = manager.Name;
        }

        public static void Deconstruct(this Employee employee, out string id, out string name)
        {
            id = employee.Id;
            name = employee.Name;
        }

    }

}
