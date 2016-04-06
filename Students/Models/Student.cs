using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Students.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Student()
        {
        }

        public Student(int id, string firstname, string lastname, string gender, int age)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            Age = age;
        }

    }
}