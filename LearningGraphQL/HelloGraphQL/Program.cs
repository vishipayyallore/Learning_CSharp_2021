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

            var nameSchema = Schema.For(@"
                type Query {
                    name: String
                }
            ");

            var nameOutput = nameSchema.Execute(_ =>
            {
                _.Query = "{ name }";
                _.Root = new { Name = "Shiva Sai" };
            });
            WriteLine($"Name Details: {nameOutput}");

            var schema = Schema.For(@"
                type Person {
                    name: String,
                    age: String
                }

                type Query{
                    person: Person
                }
            ");

            var personDetails = schema.Execute(_ =>
            {
                _.Query = "{ person { name, age } }";
                _.Root = new { Person = new { Name = "Shiva", Age = "25" } };
            });

            WriteLine($"Person Details: {personDetails}");

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }

}
