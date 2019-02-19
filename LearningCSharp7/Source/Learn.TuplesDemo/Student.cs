using System;
using System.Collections.Generic;

namespace Learn.TuplesDemo
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
    }

}
