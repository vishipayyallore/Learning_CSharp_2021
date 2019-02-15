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
            var demoTuples = new DemoTuples();
            demoTuples.ShowDemo(ConsoleColor.DarkCyan);

            var genericTryParseDemo = new GenericTryParseDemo();
            genericTryParseDemo.ShowDemo(ConsoleColor.Green);

            var outvariableDemo = new OutVariableDemo();
            outvariableDemo.ShowDemo(ConsoleColor.Magenta);

            ForegroundColor = ConsoleColor.White;

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
