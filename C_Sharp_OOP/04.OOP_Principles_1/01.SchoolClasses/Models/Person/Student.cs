using System;
using _01.SchoolClasses.Contracts;

namespace _01.SchoolClasses.Models.Person
{
    public class Student : Person, ICommentable
    {
        private int classId;

        public Student(string firstName, string lastName, int classId) : base(firstName, lastName)
        {
            this.ClassId = classId;
        }

        public Student(string firstName, string middleName, string lastName, int classId) : base(firstName, middleName, lastName)
        {
            this.ClassId = classId;
        }

        public int ClassId
        {
            get { return this.classId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Class Id must be a non negative number!");
                }
                this.classId = value;
            }
        }

        public string Comment { get; set; }
    }
}