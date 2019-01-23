using System;
using GraphQL;
using GraphQL.Types;

namespace SchemaFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schema First!");

            var schema = Schema.For(@"
                type Person {
                    id: String!,
                    name: String!
                }

                type Query{
                    employee: Person
                }
            ", _ =>
            {
                _.Types.Include<Query>();
            });

            var personDetails = schema.Execute(_ =>
            {
                _.Query = "{ employee { id, name } }";
            });

            Console.WriteLine($"Employee: {personDetails}");

        }
    }
}
