using System;

namespace _03.AnimalHierarchy
{
    public class Dog : Animal, IMakeSound
    {
        public Dog(string name) : base(name)
        {
        }

        public void MakeSound()
        {
            Console.WriteLine("Bark, Bark!");
        }
    }
}