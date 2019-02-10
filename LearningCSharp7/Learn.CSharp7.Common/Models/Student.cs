using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.CSharp7.Common.Models
{

    public class Student
    {

        public Student()
        {
        }

        public int Id { get; set; }

        public string First { get; set; }

        public string Last { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; }

        public float Salary { get; set; }

        public List<Subject> Subjects { get; set; }

        /// <summary>
        /// deconstruction using Deconstruct method
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="age"></param>
        /// <param name="salary"></param>
        public void Deconstruct(out string fullName, out int age, out float salary)
        {
            fullName = $"{First} {Last}";
            age = Age;
            salary = Salary;
        }

    }

}
