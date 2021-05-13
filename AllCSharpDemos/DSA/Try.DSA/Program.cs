using DSA.ArraysDemo;
using System;

using static System.Console;

namespace Try.DSA
{
    class Program
    {
        static void Main(string[] args)
        {

            if (DateTime.TryParse("02/02/2016", out var parsedDateTime))
            {
                WriteLine($"Parsed: {parsedDateTime}");
            }
            WriteLine($"Parsed value outside scope: {parsedDateTime}");

            if (DateTime.TryParse("InvalidDate", out parsedDateTime))
            {
                WriteLine($"Parsed: {parsedDateTime}");
            }
            WriteLine($"Parsed value outside scope: {parsedDateTime}");

            _ = int.TryParse("abc", out var i);
            WriteLine($"i = {i}"); // default value

            CalendarOperations calendarOperations = new();

            var dates = calendarOperations.GetDatesInAMonth(2, 2020);
            dates = calendarOperations.GetDatesInAMonth(2, 2024);
            dates = calendarOperations.GetDatesInAMonth(2, 2028);

            int index = 1;
            Array.ForEach(calendarOperations.GetMonthNames(), (month) =>
            {
                WriteLine($"{index++}. {month}");
            });

            WriteLine("\n\nPress any key ...");
            Read();
        }

    }

}
