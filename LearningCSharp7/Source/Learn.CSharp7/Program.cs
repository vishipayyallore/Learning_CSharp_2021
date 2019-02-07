using Learn.TuplesDemo;
using System;
using static System.Console;

namespace Learn.CSharp7
{
    static class Program
    {
        static void Main(string[] args)
        {
            

            //(string First, string Last) = ("Shiva", "Sai");

            //WriteLine($"Full Name: {First} {Last}");

            var demoTuples = new DemoTuples();
            demoTuples.ShowDemo();

            ForegroundColor = ConsoleColor.White;

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
