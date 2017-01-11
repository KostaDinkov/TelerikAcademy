namespace _03.AnimalHierarchy
{
    public class Kitten:Cat,IMakeSound
    {
        public Kitten(string name) : base(name)
        {
            this.Sex = Sex.Female;
        }

        public new Sex Sex { get; private set; }
    }
}