using ApplicationCore.Constants;
using ApplicationCore.Entities;
using FactoryPattern.Demo1;
using System;
using static System.Console;

namespace ExecuteCS678
{

    class Program
    {
        static void Main(string[] args)
        {
            Person person = null;
            var first = person?.Name ?? "Unspecified";
            WriteLine($"Name: {first}");

            // Person Class
            var person1 = new Person()
            {
                Name = "Shiva Sai",
                DateOfBirth = DateTime.Now.AddYears(-25),
                City = "Hyderabad"
            };
            WriteLine($"Person 1: {person1}");
            first = person1?.Name ?? "Unspecified";
            WriteLine($"Name: {first}");

            var clonedPerson1 = Person.Parse(person1.ToString());
            WriteLine($"Cloned Person 1: {clonedPerson1}");

            WriteLine($"{person1?.Name} === {clonedPerson1?.Name}");

            // Factory Pattern
            Employee employee = new Employee("Shiva", "Sai");
            WriteLine(employee);

            IShape rectangle = ShapeFactory.RetrieveShapeObject(Constants.Shapes.RECTANGLE);
            var shapeResponse = rectangle.GetDetails();
            WriteLine($"{shapeResponse.Name} | {shapeResponse.Description}");

            rectangle = ShapeFactory.RetrieveShapeObject(Constants.Shapes.SQUARE);
            shapeResponse = rectangle.GetDetails();
            WriteLine($"{shapeResponse.Name} | {shapeResponse.Description}");

            rectangle = ShapeFactory.RetrieveShapeObject(Constants.Shapes.UNKNOWN);
            shapeResponse = rectangle.GetDetails();
            WriteLine($"{shapeResponse.Name} | {shapeResponse.Description}");

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }

}
