namespace _02.StudentsAndWorkers.Models
{
    public abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        protected Human(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
