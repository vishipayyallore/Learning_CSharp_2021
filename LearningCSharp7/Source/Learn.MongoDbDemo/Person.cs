using System;

namespace Learn.MongoDbDemo
{
    public class Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public DateTime EnrolledOn { get; set; }
    }

}
