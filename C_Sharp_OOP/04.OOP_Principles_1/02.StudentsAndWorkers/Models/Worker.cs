using System.Text;
using _02.StudentsAndWorkers.Contracts;

namespace _02.StudentsAndWorkers.Models
{
    public class Worker:Human, IWorker
    {
        public decimal WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return (this.WeekSalary / 5m) / this.WorkHoursPerDay;
        }

        public Worker(string firstName, string lastName) : base(firstName, lastName)
        {
            this.WorkHoursPerDay = 8;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"\nMoney per hour: {this.MoneyPerHour()}");

            return sb.ToString();
        }
    }
}