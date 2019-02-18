using Learn.CSharp7.Common;
using System;
using static System.Console;

namespace Learn.MiscDemo
{
    /// <summary>
    /// Discard => write-only variable whose name is _ (underscore character).
    /// </summary>
    public class DiscardsDemo : IDataTypeDemo
    {
        public void ShowDemo(ConsoleColor foreGroundColor)
        {
            ForegroundColor = foreGroundColor;

            var (_, Name, _, Salary) = (1, "Shiva Sai", 25, 123.45);
            WriteLine($"Name: {Name}, Salary: {Salary}");
        }

    }

}
