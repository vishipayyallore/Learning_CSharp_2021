using System;
using static System.Console;

namespace Learn.CSharp7
{
    static class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.DarkCyan;

            var fullName = (First: "Shiva", Last: "Sai");

            WriteLine($"Full Name: {fullName.First} {fullName.Last}");

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
