using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    public class Student
    {
        public Student()
        {
            this.Marks = new List<double>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public ulong GroupNumber { get; set; }

        public uint Age { get; set; }

        public List<double> Marks { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("First Name: " + this.FirstName);
            sb.AppendLine("Last Name: " + this.LastName);
            sb.AppendLine("Age: " + this.Age);
            sb.AppendLine("Email: " + this.Email);
            sb.AppendLine("Group Number: " + this.GroupNumber);
            sb.AppendLine(new string('-', 50));


            return sb.ToString();
        }

        
    }
}