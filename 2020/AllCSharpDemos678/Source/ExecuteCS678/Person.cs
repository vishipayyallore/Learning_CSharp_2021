using System;
using System.Text.Json;

using static System.Console;

namespace ExecuteCS678
{
    public class Person
    {
        public Guid Id { get; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string City { get; set; }

        public Person()
        {
            Id = Guid.NewGuid();
        }

        public void Introduce(Person person) => WriteLine($"Hi {person.Name}, I am {Name}");

        public override string ToString() => JsonSerializer.Serialize(this);

        public static Person Parse(string personInformation) => JsonSerializer.Deserialize<Person>(personInformation);
    }

}
