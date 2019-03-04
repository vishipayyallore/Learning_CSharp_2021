using Learn.CSharp7.Common;
using Learn.CSharp7.Common.Utilis;
using static System.Console;

namespace Learn.MiscDemo
{

    /// <summary>
    /// 
    /// </summary>
    public class ExtensionMethodsDemo : IDataTypeDemo
    {
        public string Title => GetType().Name;

        public void ShowDemo()
        {
            string input = "125";
            var (value, parsed) = input.ParseToInteger();
            WriteLine($"Integer Try Parse Using Extension Method: {input} = {value}");

            input = "125.45";
            (value, parsed) = input.ParseToInteger();
            WriteLine($"Integer Try Parse Using Extension Method: {input} = {value}");

            input = "ABC";
            (value, parsed) = input.ParseToInteger();
            WriteLine($"Integer Try Parse Using Extension Method: {input} = {value}");
        }
    }

}
