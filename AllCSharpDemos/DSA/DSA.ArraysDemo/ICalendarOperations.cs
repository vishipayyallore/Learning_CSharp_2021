using System;
using System.Collections.Generic;

namespace DSA.ArraysDemo
{

    public interface ICalendarOperations
    {
        string[] GetMonthNames();

        List<DateTime> GetDatesInAMonth(int month, int year);
    }

}
