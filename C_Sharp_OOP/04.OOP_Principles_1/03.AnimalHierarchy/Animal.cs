namespace _03.AnimalHierarchy
{
    public abstract class Animal
    {
        protected Animal(string name)
        {
            this.Name = name;
        }

        public double Age { get; set; }
        public string Name { get; set; }

        public  Sex Sex { get; set; }
    }
}