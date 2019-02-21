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

            var person1 = new Person { Age = 24, FirstName = "Alex", LastName = "Pandian" };

            persons.InsertOne(person1);

        }

    }

}
