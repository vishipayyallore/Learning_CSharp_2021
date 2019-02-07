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

            ForegroundColor = ConsoleColor.White;

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
