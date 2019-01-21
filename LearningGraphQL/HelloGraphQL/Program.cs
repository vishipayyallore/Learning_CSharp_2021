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

            WriteLine($"{personDetails}");

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }

}
