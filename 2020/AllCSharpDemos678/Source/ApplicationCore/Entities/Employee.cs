using System;

namespace ApplicationCore.Entities
{

    public class Employee
    {
        public Guid Id { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Employee(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Id: {Id} | First: {FirstName} | Last: {LastName}";
        }
    }

}
