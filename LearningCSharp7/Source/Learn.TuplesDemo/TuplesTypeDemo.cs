using Learn.CSharp7.Common;
using System;
using static System.Console;

namespace Learn.TuplesDemo
{
    public class DemoTuples : IDemoDataType
    {

        public void ShowDemo(ConsoleColor foreGroundColor)
        {
            ForegroundColor = foreGroundColor;

            // Simple Demo
            var fullName = ("Shiva", "Sai");

            WriteLine($"Full Name: {fullName.Item1} {fullName.Item2}");
        }

    }

}
