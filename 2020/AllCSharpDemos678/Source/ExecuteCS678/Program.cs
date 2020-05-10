using ApplicationCore.Entities;

using static System.Console;

namespace ExecuteCS678
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Shiva", "Sai");
            WriteLine(employee);

            var rectangle = ShapeFactory.RetrieveShapeObject("Rectangle");
            var shapeResponse = rectangle.GetDetails();
            WriteLine($"{shapeResponse.Name} | {shapeResponse.Description}");

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }

}
