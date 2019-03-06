using Learn.CSharp7.Common.Utilis;
using Learn.MiscDemo;
using Learn.MongoDbDemo;
using Learn.TuplesDemo;
using System;
using System.Collections.Generic;
using static System.Console;

namespace Learn.CSharp7
{
    static class Program
    {
        static void Main(string[] args)
        {

            // ---------------------------- For Quick Experiments -----------------------------------------
            var student = new Common.Models.Student()
            {
                Id = 101,
                First = "Shiva",
                Last = "Sai",
                DateOfBirth = DateTime.Now.AddYears(-25),
                Salary = 123.45f,
                Subjects = new List<Common.Models.Subject> { new Common.Models.Subject { Name = "Computers", Marks = 78.89f } }
            };

            // Student Deconstruction
            var (fullName, age, salary) = student;
            WriteLine($"Student Deconstruction: {fullName} {age} {salary}");

            var (name, marks) = student.Subjects[0];
            WriteLine($"Subject Deconstruction: {name} {marks}");

            var mongoDemos = new StoreNRetrievePerson();
            mongoDemos.SavePerson();

            // ---------------------------------------------------------------------
            var demoHelper = new DemoHelper();

            demoHelper
                .ShowDemoOf(new ExtensionMethodsDemo(), ConsoleColor.DarkMagenta)
                .ShowDemoOf(new DemoTuples(), ConsoleColor.DarkCyan)
                .ShowDemoOf(new GenericTryParseDemo(), ConsoleColor.Green)
                .ShowDemoOf(new OutVariableDemo(), ConsoleColor.Magenta)
                .ShowDemoOf(new DiscardsDemo(), ConsoleColor.Cyan)
                .ShowDemoOf(new PatternMatchingDemo(), ConsoleColor.Red);

            ForegroundColor = ConsoleColor.White;

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

    }

}
