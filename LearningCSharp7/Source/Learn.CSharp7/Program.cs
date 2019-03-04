using Learn.CSharp7.Common.Utilis;
using Learn.MiscDemo;
using Learn.MongoDbDemo;
using Learn.TuplesDemo;
using System;
using static System.Console;

namespace Learn.CSharp7
{
    static class Program
    {
        static void Main(string[] args)
        {

            // ---------------------------- For Quick Experiments -----------------------------------------
            string input = "125";
            var (value, parsed) = input.ParseToInteger();
            WriteLine($"Integer Try Parse Using Extension Method: {input} = {value}");

            input = "125.45";
            (value, parsed) = input.ParseToInteger();
            WriteLine($"Integer Try Parse Using Extension Method: {input} = {value}");

            input = "ABC";
            (value, parsed) = input.ParseToInteger();
            WriteLine($"Integer Try Parse Using Extension Method: {input} = {value}");

            // Out Variable Demo
            int.TryParse(input, out int outputNumber);
            WriteLine($"Out Variable Demo : {input} = {outputNumber}");

            // ---------------------------------------------------------------------
            var mongoDemos = new StoreNRetrievePerson();
            mongoDemos.SavePerson();

            // ---------------------------------------------------------------------
            var demoHelper = new DemoHelper();

            demoHelper.ShowDemoOf(new DemoTuples(), ConsoleColor.DarkCyan)
                .ShowDemoOf(new GenericTryParseDemo(), ConsoleColor.Green)
                .ShowDemoOf(new OutVariableDemo(), ConsoleColor.Magenta)
                .ShowDemoOf(new DiscardsDemo(), ConsoleColor.Cyan)
                .ShowDemoOf(new PatternMatchingDemo(), ConsoleColor.Red);

            ForegroundColor = ConsoleColor.White;

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

    }

}
