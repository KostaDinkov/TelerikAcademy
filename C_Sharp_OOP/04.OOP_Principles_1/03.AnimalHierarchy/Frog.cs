using System;

namespace _03.AnimalHierarchy
{
    public class Frog:Animal,IMakeSound
    {
        public Frog(string name) : base(name)
        {
        }

        public void MakeSound()
        {
            Console.WriteLine("Croak, Croak!");
        }
    }
}