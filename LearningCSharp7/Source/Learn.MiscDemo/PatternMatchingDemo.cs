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

            var manager = new Manager { Id = "M101", Name = "Ashish", Repotees = new List<string> { "Jagan", "Abhishek", "Swamy" } };
            DisplayInformation(manager);
        }

        // is expression pattern matching
        private void DisplayInformation(object person)
        {
            if (person is Employee employee)
            {
                WriteLine($"Id= {employee.Id}, Name= {employee.Name}, Task Codes= {string.Join<int>(", ", employee.TaskCodes)} ");
            }
            if (person is Manager manager)
            {
                WriteLine($"Id= {manager.Id}, Name= {manager.Name}, Repotees= {string.Join<string>(", ", manager.Repotees)} ");
            }
        }

        private void DisplayInformationUsingSwitch(object person)
        {
            switch (person)
            {
                case Employee employee:
                    WriteLine($"Id= {employee.Id}, Name= {employee.Name}, Task Codes= {string.Join<int>(", ", employee.TaskCodes)} ");
                    break;
                case Manager manager:
                    WriteLine($"Id= {manager.Id}, Name= {manager.Name}, Repotees= {string.Join<string>(", ", manager.Repotees)} ");
                    break;
                default:
                    break;
            }
        }

    }
}
