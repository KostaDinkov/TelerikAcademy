using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOTE: Even better! Instead of creating different lists of concrete animals, I put them all in one collection.
            List<Animal> animals = new List<Animal>
                                   {
                                       new Tomcat("Jimmy") {Age = 3},
                                       new Kitten("Penny") {Age = 3.5},
                                       new Frog("Kermit") {Age = 20},
                                       new Frog("Greenie") {Age = 11},
                                       new Tomcat("Joe") {Age = 5},
                                       new Kitten("Sue") {Age = 1},
                                       new Dog("Allan") {Age = 3.1},
                                       new Dog("Frodo") {Age = 6},
                                       new Dog("Eddie") {Age = 4}
                                   };


            
            //Then, using reflection, I get the name of the concrete type
            //and use it to group the animals by type.
            //Then I cast the result to anonymous type, containing the animal type
            //and the average age of all the animals in the grouping;
            var query = animals.GroupBy(a => a.GetType().Name,
                                        a => a.Age,
                                        (key, g) => new
                                                    {
                                                        AnimalType = key,
                                                        AverageAge = g.Average()
                                                    });


            foreach (var element in query)
            {
                Console.WriteLine($"Animal Type: {element.AnimalType}, Average age: {element.AverageAge}");
            }
        }
    }
}