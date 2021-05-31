using DSA.ArraysDemo;
using System;

using static System.Console;

namespace Try.DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            ForegroundColor = ConsoleColor.Yellow;

            Array.ForEach(daysOfWeek, (label) => Write($"{label,10} | "));
            WriteLine();

            CalendarOperations calendarOperations = new();

            var dates = calendarOperations.GetDatesInAMonth(5, 2021);
            var index = Array.IndexOf<string>(daysOfWeek, dates[0].DayOfWeek.ToString());

            ForegroundColor = ConsoleColor.Cyan;
            for (var counter = 0; counter < index; counter++)
            {
                Write($"{string.Empty,10} | ");
            }

            dates.ForEach((currentDay) =>
            {
                ForegroundColor = (index < 5) ? ConsoleColor.Cyan : ConsoleColor.Gray;
                Write($"{currentDay.ToShortDateString(),10} | ");
                index++;
                if (index >= 7)
                {
                    WriteLine();
                    index = 0;
                }
            });

            WriteLine($"{daysOfWeek[0]} | {daysOfWeek[1]}");

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

            //CalendarOperations calendarOperations = new();

            //var dates = calendarOperations.GetDatesInAMonth(2, 2020);
            //dates = calendarOperations.GetDatesInAMonth(2, 2024);
            //dates = calendarOperations.GetDatesInAMonth(2, 2028);

            //int index = 1;
            //Array.ForEach(calendarOperations.GetMonthNames(), (month) =>
            //{
            //    WriteLine($"{index++}. {month}");
            //});

            WriteLine("\n\nPress any key ...");
            Read();
        }

    }

}
