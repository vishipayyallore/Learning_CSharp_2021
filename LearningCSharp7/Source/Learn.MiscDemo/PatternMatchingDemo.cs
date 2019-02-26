using Learn.CSharp7.Common;
using Learn.CSharp7.Common.Models;
using System.Collections.Generic;
using static System.Console;

namespace Learn.MiscDemo
{
    public class PatternMatchingDemo : IDataTypeDemo
    {
        public string Title => GetType().Name;

        public void ShowDemo()
        {

            var employee = new Employee { Id = "E101", Name = "Anil", TaskCodes = new List<int> { 101, 102, 103, 104 } };
            DisplayInformation(employee);

            // is expression pattern matching
        }


        private void DisplayInformation(object person)
        {
            if (person is Employee employee)
            {
                WriteLine($"Id= {employee.Id}, Name= {employee.Name}, Task Codes= {string.Join<int>(", ", employee.TaskCodes)} ");
            }
        }

    }
}
