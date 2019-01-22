using System;
using GraphQL;
using GraphQL.Types;

using static System.Console;

namespace HelloGraphQL
{

    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Green;

            var sampleQuery = new SampleQuery();

            var nameOutput = sampleQuery.ShowSinglePropertyDemo();
            WriteLine($"Name Details: {nameOutput}");

            var personDetails = sampleQuery.ShowMultiPropertiesDemo();
            WriteLine($"Person Details: {personDetails}");

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }

}
