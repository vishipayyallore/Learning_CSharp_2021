using MongoDB.Driver;
using System;

namespace Learn.MongoDbDemo
{

    public class StoreNRetrievePerson
    {

        public void SavePerson()
        {
            var mongoDbClient = new MongoClient();
            var dataBase = mongoDbClient.GetDatabase("test");
            var persons = dataBase.GetCollection<Person>("persons");

            var person1 = new Person { Age = 24, FirstName = "Alex", LastName = "Pandian" };

            persons.InsertOne(person1);
        }

    }

    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }

}
