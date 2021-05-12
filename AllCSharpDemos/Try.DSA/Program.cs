using System;

namespace Try.DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            CalendarOperations calendarOperations = new();

            var dates = calendarOperations.GetDatesInAMonth(2, 2020);
            dates = calendarOperations.GetDatesInAMonth(2, 2024);
            dates = calendarOperations.GetDatesInAMonth(2, 2028);

            int index = 1;
            Array.ForEach(calendarOperations.GetMonthNames(), (month) => { Console.WriteLine($"{index++}. {month}"); });

            Console.WriteLine("\n\nPress any key ...");
            Console.Read();
        }

        //private static string[] GetMonthNames()
        //{
        //    string[] months = new string[12];

        //    for (int month = 1; month <= 12; month++)
        //    {
        //        months[month - 1] = new DateTime(DateTime.Now.Year, month, 1)
        //                                .ToString("MMMM", CultureInfo.CreateSpecificCulture("en-in"));
        //    }

        //    return months;
        //}

        //// generate dates for all days in the month
        //private static List<DateTime> GetDatesInAMonth(int month, int year)
        //{
        //    return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
        //        .Select(x => new DateTime(year, month, x))
        //        .ToList();
        //}

    }

}
