using GraphQL;
using GraphQL.Types;

namespace HelloGraphQL
{

    // Schema First Approach
    public class SampleQuery
    {

        public SampleQuery()
        {
        }

        public string ShowSinglePropertyDemo()
        {
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

            return nameOutput;
        }

        public string ShowMultiPropertiesDemo()
        {
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

            return personDetails;
        }

    }

}