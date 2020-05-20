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
            System.Data.DataSet ds; 
            System.Net.Http.HttpClient client;

            var index = 1;
            foreach( var currentAssembly in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                WriteLine($"{index++}. {currentAssembly.Name}");
                WriteLine("=========================================");

                // Load Current Assembly
                var assembly = Assembly.Load(new AssemblyName(currentAssembly.FullName));
                
                var totalMethods = 0;
                foreach(var currentType in assembly.DefinedTypes)
                {
                    var methodCount = currentType.GetMethods().Count();
                    // WriteLine( $"\t{currentType.FullName} - Method Count: {methodCount}");
                    
                    totalMethods += methodCount;
                }

                Console.WriteLine( $"{assembly.DefinedTypes.Count():N0} types with {totalMethods:N0} methods in {currentAssembly.Name} assembly.");
                WriteLine("------------------------------------------------\n\n");
            }

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
