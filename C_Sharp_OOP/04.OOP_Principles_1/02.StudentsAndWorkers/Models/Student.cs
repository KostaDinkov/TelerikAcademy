using System.Text;

namespace _02.StudentsAndWorkers.Models
{
    public class Student : Human
    {
        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
            
        }

        public double Grade { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"\nGrade: {this.Grade}");
            return sb.ToString();
        }
    }
}