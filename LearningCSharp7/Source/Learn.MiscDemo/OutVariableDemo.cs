using Learn.CSharp7.Common;
using System;
using static System.Console;

namespace Learn.MiscDemo
{
    public class OutVariableDemo : IDataTypeDemo
    {
        public void ShowDemo(ConsoleColor foreGroundColor)
        {
            ForegroundColor = foreGroundColor;

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
