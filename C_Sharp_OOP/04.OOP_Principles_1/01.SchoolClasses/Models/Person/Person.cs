using System;

namespace _01.SchoolClasses.Models.Person
{
    public class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(string firstName, string middleName, string lastName) : this(firstName, lastName)
        {
            this.MiddleName = middleName;
        }

        // a unique person identifier, used in case of an Entity Framework integration; The database will automatically generate the Id
        public int Id { get; private set; }
        
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name must not be null or empty!");
                }
                this.firstName = value;
            }
        }

        public string MiddleName { get; set; }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name must not be null or empty!");
                }
                this.lastName = value;
            }
        }
    }
}