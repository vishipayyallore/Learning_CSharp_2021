using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Try.DSA
{
    public class CalendarOperations : ICalendarOperations
    {

        public string[] GetMonthNames()
        {
            string[] months = new string[12];

            for (int month = 1; month <= 12; month++)
            {
                months[month - 1] = new DateTime(DateTime.Now.Year, month, 1)
                                        .ToString("MMMM", CultureInfo.CreateSpecificCulture("en-in"));
            }

            return months;
        }

        public List<DateTime> GetDatesInAMonth(int month, int year)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
                .Select(x => new DateTime(year, month, x))
                .ToList();
        }

    }

}
