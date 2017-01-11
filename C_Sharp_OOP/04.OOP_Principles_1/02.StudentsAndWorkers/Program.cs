using System;
using System.Collections.Generic;
using System.Linq;
using _02.StudentsAndWorkers.Models;

namespace _02.StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
                           {
                               new Student("Ahsoka", "Tano") {Grade = 4},
                               new Student("Ezra", "Bridger") {Grade = 3},
                               new Student("Sabine", "Wren") {Grade = 4},
                               new Student("Kanan", "Jarus") {Grade = 5},
                               new Student("Hera", "Syndulla") {Grade = 6},
                               new Student("C1", "10P") {Grade = 3.5},
                               new Student("Ben", "Solo") {Grade = 2},
                               new Student("Anakin", "Skywalker") {Grade = 2.5},
                               new Student("Zett", "Jukassa") {Grade = 5.5},
                               new Student("Caleb", "Dume") {Grade = 4.5}
                           };
            var workers = new List<Worker>
                          {
                              new Worker("Depa", "Billaba") {WeekSalary = 100},
                              new Worker("Ima-Gun", "Di") {WeekSalary = 200},
                              new Worker("Cin", "Dralling") {WeekSalary = 300},
                              new Worker("Kit", "Fisto") {WeekSalary = 400},
                              new Worker("Adi", "Gallia") {WeekSalary = 455},
                              new Worker("Qui-Gon", "Jin") {WeekSalary = 555},
                              new Worker("Obi-Wan", "Kenobi") {WeekSalary = 194},
                              new Worker("Shaak", "Ti") {WeekSalary = 670},
                              new Worker("Mace", "Windu") {WeekSalary = 490},
                              new Worker("Yoda", "") {WeekSalary = 1000}
                          };

            var sortedStudents = students.OrderBy(s => s.Grade);
            Console.WriteLine("Students, sorted by grade, ascending:");
            Console.WriteLine(string.Join("-\n", sortedStudents));

            var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour());
            Console.WriteLine("Workers, sortred by money per hour, descending:");
            Console.WriteLine(string.Join("-\n", sortedWorkers));

            var merged = new List<Human>();

            foreach (Worker worker in workers)
            {
                merged.Add(worker);
            }
            foreach (Student student in students)
            {
                merged.Add(student);
            }

            Console.WriteLine("Press any key to proceed!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("All classes of type Human, sorted by First Name and Last Name");
            var sortedHumans = merged.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
            Console.WriteLine(string.Join("-\n", sortedHumans));
        }
    }
}