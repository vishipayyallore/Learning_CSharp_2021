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

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }

}
