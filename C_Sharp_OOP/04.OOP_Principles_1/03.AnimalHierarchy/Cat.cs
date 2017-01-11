using System;

namespace _03.AnimalHierarchy
{
   public class Cat:Animal,IMakeSound
    {
        public Cat(string name) : base(name)
        {
        }

        public void MakeSound()
        {
            Console.WriteLine("Miau, Miau!");
        }
    }
}