using Learn.CSharp7.Common;
using Learn.MiscDemo;
using Learn.TuplesDemo;
using System;
using static System.Console;

namespace Learn.CSharp7
{
    static class Program
    {
        static void Main(string[] args)
        {

            ShowDemoOf(new DemoTuples(), ConsoleColor.DarkCyan);

            // var demoTuples = new DemoTuples();
            // demoTuples.ShowDemo(ConsoleColor.DarkCyan);

            var genericTryParseDemo = new GenericTryParseDemo();
            genericTryParseDemo.ShowDemo(ConsoleColor.Green);

            var outvariableDemo = new OutVariableDemo();
            outvariableDemo.ShowDemo(ConsoleColor.Magenta);

            var discardsDemo = new DiscardsDemo();
            discardsDemo.ShowDemo(ConsoleColor.Cyan);

            ForegroundColor = ConsoleColor.White;

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        private static void ShowDemoOf(IDataTypeDemo dataTypeDemo, ConsoleColor foreGroundColor)
        {
            ForegroundColor = foreGroundColor;

            WriteLine($"==================== {dataTypeDemo.Title} ====================");

            WriteLine($"-------------------- {dataTypeDemo.Title} --------------------");

            ForegroundColor = ConsoleColor.White;
        }

    }

}
