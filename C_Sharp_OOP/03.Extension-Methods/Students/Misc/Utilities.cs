using System;
using System.Collections.Generic;
using Homework.Models;

namespace Homework.Misc
{
    public static class Utilities
    {
        /// <summary>
        /// Prints all elements from an IEnumerable collection to the system console
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        public static void PrintToConsole<T>(this IEnumerable<T> collection)
        {
            foreach (T element in collection)
            {
                Console.WriteLine(element);
            }
        }

        public static void PrintDescription(string problemDescription)
        {
            int consoleWidth = Console.WindowWidth;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(new string('_', consoleWidth));
            Console.WriteLine(problemDescription);
            Console.WriteLine(new string('_', consoleWidth));
            Console.ResetColor();
        }

        public static void Pause()
        {
            Console.WriteLine("Press any key to continue to the next problem...");
            Console.ReadKey();
            Console.Clear();
        }

        public static string GetEmailDomain(string email)
        {
            int lastAtIndex = email.LastIndexOf("@");
            string domain = email.Substring(lastAtIndex + 1);
            return domain;
        }

        public static List<Student> GenerateStudents()
        {
            var students = new List<Student>();

            students.Add(new Student
            {
                FirstName = "Obi-Wan",
                LastName = "Kenobi",
                Email = "master_ftw@jedi.org",
                Age = 100,
                FN = "328577",
                GroupNumber = 2,
                Marks = new List<double> { 10, 9, 10, 10, 8, 7.5, 9.1 },
                PhoneNumber = "02 345 444"
            });
            students.Add(new Student
            {
                FirstName = "Luke",
                LastName = "Skywalker",
                Email = "im_awsome@jedi.org",
                Age = 30,
                FN = "434577",
                GroupNumber = 2,
                Marks = new List<double> { 2, 9, 4, 10, 8, 6, 4 },
                PhoneNumber = "01 345 444"
            });
            students.Add(new Student
            {
                FirstName = "Kylo",
                LastName = "Ren",
                Age = 22,
                Email = "angry_white_dude@first_order.gov",
                FN = "271625",
                GroupNumber = 3,
                Marks = new List<double> { 10, 5, 2, 2, 1, 3, -10 },
                PhoneNumber = "0456 345 444"
            });
            students.Add(new Student
            {
                FirstName = "Hera",
                LastName = "Syndulla",
                Age = 28,
                Email = "girl_power@rebels.org",
                FN = "342106",
                GroupNumber =4,
                Marks = new List<double> { 10, 9, 8, 9, 7, 9, 9 },
                PhoneNumber = "02 345 444"
            });

            students.Add(new Student
            {
                FirstName = "Sabine",
                LastName = "Wren",
                Age = 17,
                Email = "anarchy@rebels.org",
                FN = "704706",
                GroupNumber = 4,
                Marks = new List<double> { 6, 9, 8, 7, 7, 8, 9 },
                PhoneNumber = "0724 345 444"
            });


            return students;
        }
    }
}