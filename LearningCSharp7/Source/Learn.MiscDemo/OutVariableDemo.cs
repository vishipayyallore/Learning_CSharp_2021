using Learn.CSharp7.Common;
using System;

namespace Learn.MiscDemo
{
    public class OutVariableDemo : IDataTypeDemo
    {
        public string Title => GetType().Name;

        public void ShowDemo()
        {
            var input1 = "12345";
            TryParseV1(input1);
            TryParseV2(input1);

            // Changing to Non-Numeric value
            input1 = "ABC";
            TryParseV1(input1);
            TryParseV2(input1);
        }

        private void TryParseV1(string input)
        {
            int output;
            if (int.TryParse(input, out output))
            {
                Console.WriteLine($"Input: {input}, Output: {output}");
            }
            else
            {
                Console.WriteLine($"Could not parse {input}, Output: {output}");
            }
        }

        private void TryParseV2(string input)
        {
            if (int.TryParse(input, out var output))
            {
                Console.WriteLine($"Input: {input}, Output: {output}");
            }
            else
            {
                Console.WriteLine($"Could not parse {input}, Output: {output}");
            }
        }

    }

}
