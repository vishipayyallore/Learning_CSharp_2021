using System;
using System.Collections.Generic;

namespace Learn.CSharp7.Common.Models
{

    public class Student
    {

        public Student()
        {
            Subjects = new List<Subject>();
        }

        public int Id { get; set; }

        public string First { get; set; }

        public string Last { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; }

        public float Salary { get; set; }

        public List<Subject> Subjects { get; set; }

    }

}
