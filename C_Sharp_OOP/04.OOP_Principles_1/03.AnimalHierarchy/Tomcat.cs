namespace _03.AnimalHierarchy
{
    class Tomcat : Cat
    {
        public Tomcat(string name) : base(name)
        {
            this.Sex = Sex.Male;
        }

        public new Sex Sex { get; private set; }
    }
}