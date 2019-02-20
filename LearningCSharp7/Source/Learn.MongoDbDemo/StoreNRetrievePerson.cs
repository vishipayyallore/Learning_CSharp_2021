using MongoDB.Driver;

namespace Learn.MongoDbDemo
{

    public class StoreNRetrievePerson
    {

        public void SavePerson()
        {
            var mongoDbClient = new MongoClient();
            var dataBase = mongoDbClient.GetDatabase("test");
            var persons = dataBase.GetCollection<Person>("persons");

            var person1 = new Person { Id = 125, Age = 24, FirstName = "Alex", LastName = "Pandian" };

            persons.InsertOne(person1);

        }

    }

    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }

}
