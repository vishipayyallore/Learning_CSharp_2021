using Learn.CSharp7.Common;
using System;
using static System.Console;

namespace Learn.CSharp7
{
    public class DemoHelper
    {

        public DemoHelper ShowDemoOf(IDataTypeDemo dataTypeDemo, ConsoleColor foreGroundColor)
        {
            ForegroundColor = foreGroundColor;

            WriteLine($"==================== {dataTypeDemo.Title} ====================");

            dataTypeDemo.ShowDemo();

            WriteLine($"-------------------- {dataTypeDemo.Title} --------------------\n\n");

            return this;
        }

    }
}
