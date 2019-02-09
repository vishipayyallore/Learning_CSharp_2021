using Learn.CSharp7.Common;
using System;
using static System.Console;

namespace Learn.TuplesDemo
{
    public class DemoTuples : IDemoDataType
    {
        /// <summary>
        /// Tuples Type and Tuples Literal: Returning multiple values from methods. Tuples are ValueType/Structs
        /// </summary>
        /// <param name="foreGroundColor"></param>
        public void ShowDemo(ConsoleColor foreGroundColor)
        {
            ForegroundColor = foreGroundColor;

            // Tuple Literal
            var fullName = ("Shiva", "Sai");    
            WriteLine($"Full Name: {fullName.Item1} {fullName.Item2}");

            (string, string) fullName1 = ("Shiva", "Sai");
            WriteLine($"Full Name: {fullName1.Item1} {fullName1.Item2}");

            var fullName2 = (First: "Shiva", Last: "Sai");
            WriteLine($"Full Name: {fullName2.First} {fullName2.Last}");

            // Need to show case this from Method.
            (string First, string Last) fullName3 = GetFullName3();
            WriteLine($"Full Name: {fullName3.First} {fullName3.Last}");

            // Tuple Type
            (string First, string Last) fullNameN = ("Manish", "Aggarwal");
            WriteLine($"Full Name: {fullNameN.First} {fullNameN.Last}");


        }

        private static (string FName, string LName) GetFullName3()
        {
            return (FName: "Manish", LName: "Aggarwal");
        }

    }

}
