using System;
using System.Linq;
using System.Reflection;

using static System.Console;

namespace first_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            foreach( var currentAssembly in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                WriteLine($"{currentAssembly.Name}");
            }

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
