using System.Collections.Generic;
using _01.SchoolClasses.Contracts;

namespace _01.SchoolClasses.Models.Person
{
    public class Teacher : Person, ICommentable
    {
        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Teacher(string firstName, string middleName, string lastName) : base(firstName, middleName, lastName)
        {
            this.Disciplines = new HashSet<Discipline>();
        }

        public virtual ICollection<Discipline> Disciplines { get; set; } // using virtual as per Entity Framework convention
        public string Comment { get; set; }
    }
}