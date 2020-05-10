using ApplicationCore.Entities;
using FactoryPattern.Demo1;
using static System.Console;

namespace ExecuteCS678
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Shiva", "Sai");
            WriteLine(employee);

            IShape rectangle = ShapeFactory.RetrieveShapeObject("Rectangle");
            var shapeResponse = rectangle.GetDetails();
            WriteLine($"{shapeResponse.Name} | {shapeResponse.Description}");

            rectangle = ShapeFactory.RetrieveShapeObject("Square");
            shapeResponse = rectangle.GetDetails();
            WriteLine($"{shapeResponse.Name} | {shapeResponse.Description}");

            rectangle = ShapeFactory.RetrieveShapeObject("Unknown");
            shapeResponse = rectangle.GetDetails();
            WriteLine($"{shapeResponse.Name} | {shapeResponse.Description}");

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }

}
