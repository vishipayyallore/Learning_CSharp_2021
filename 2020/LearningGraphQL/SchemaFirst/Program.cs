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

                type PersonQuery {
                    employee: Person
                }
            ", _ =>
            {
                _.Types.Include<PersonQuery>();
            });

            var personDetails = schema.Execute(_ =>
            {
                _.PersonQuery = "{ employee { id, name } }";
            });

            Console.WriteLine($"Employee: {personDetails}");

        }
    }
}
