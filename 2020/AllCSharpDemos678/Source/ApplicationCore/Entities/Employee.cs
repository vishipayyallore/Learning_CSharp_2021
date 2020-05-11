using System;

namespace ApplicationCore.Entities
{

    public class Employee
    {
        public Guid Id { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; } = "UnKnown"; /* Initialize backing fields for auto-properties */

        public Employee(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName ?? throw new ArgumentException($"{nameof(firstName)} cannot be null");
            LastName = lastName ?? throw new ArgumentException($"{nameof(lastName)} cannot be null");
            
            // TODO: Replace with Data Annotations.
            if (IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException($"{nameof(firstName)} cannot be empty.");
            }

            if (IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException($"{nameof(lastName)} cannot be empty.");
            }

            FullName = $"{FirstName} {LastName}";
        }

        public override string ToString()
        {
            return $"Id: {Id} | First: {FirstName} | Last: {LastName} | FullName: {FullName}";
        }

        private bool IsNullOrWhiteSpace(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }

}
