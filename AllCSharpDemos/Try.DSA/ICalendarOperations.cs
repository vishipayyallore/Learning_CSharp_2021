using System;
using System.Collections.Generic;

namespace Try.DSA
{

    public interface ICalendarOperations
    {
        string[] GetMonthNames();

        List<DateTime> GetDatesInAMonth(int month, int year);
    }

}
