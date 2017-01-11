using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Homework.ExtensionMethods;
using Homework.Misc;
using Homework.Models;

namespace Homework
{
    public static class Problems
    {
        private static readonly List<Student> students = Utilities.GenerateStudents();

        public static void Problem1()
        {
            Utilities.PrintDescription(Descriptions.Problem1);

            StringBuilder sb = new StringBuilder("Jedi Master");
            int index = 4;
            int length = 5;

            Console.WriteLine(
                $"Substring of {sb} with index {index} and length {length} is :{sb.Substring(index, length)}");
        }

        public static void Problem2()
        {
            Utilities.PrintDescription(Descriptions.Problem2);

            int[] numbers = {1, 5, 8, -3, 4, 110};
            string[] strings = {"I", "Am", "Sith", "Overlord"};

            //Print Mins
            Console.WriteLine($"Min of [{string.Join(", ", numbers)}] is : {numbers.MyMin()}");
            Console.WriteLine($"Min of [{string.Join(", ", strings)}] is : {strings.MyMin()}");

            //Print Max
            Console.WriteLine($"Max of [{string.Join(", ", numbers)}] is : {numbers.MyMax()}");
            Console.WriteLine($"Max of [{string.Join(", ", strings)}] is : {strings.MyMax()}");

            //Print Sum - assuming T is of a numeric type (int, double, etc)
            Console.WriteLine($"The sum of [{string.Join(", ", numbers)}] is : {numbers.MySum()}");

            //Print Average - assuming as above
            Console.WriteLine($"The average of [{string.Join(", ", numbers)}] is : {numbers.MyAverage()}");

            //Print Product - as above
            Console.WriteLine($"The product of [{string.Join(", ", numbers)}] is : {numbers.MyProduct()}");
        }

        public static void Problem3()
        {
            Utilities.PrintDescription(Descriptions.Problem3);

            var query = from student in students
                         where string.Compare(student.FirstName, student.LastName, StringComparison.Ordinal) < 0
                         select student;
            query.PrintToConsole();
            //alternative using method syntax
            //students.Where(student => string.Compare(student.FirstName, student.LastName, StringComparison.Ordinal) < 0)
            //        .PrintToConsole();
            
        }

        public static void Problem4()
        {
            Utilities.PrintDescription(Descriptions.Problem4);

            var query = from student in students
                        where student.Age >= 18 && student.Age <= 24
                        select new {student.FirstName, student.LastName};

            foreach (var result in query)
            {
                Console.WriteLine($"{result.FirstName} {result.LastName}");
            }
            
            //alternative using method syntax
            //students.Where(student => (student.Age >= 18) && (student.Age <= 24))
            //        .Select(s => new { s.FirstName, s.LastName })
            //        .PrintToConsole();
        }

        public static void Problem5()
        {
            Utilities.PrintDescription(Descriptions.Problem5);

            //with linq method syntax
            students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName).PrintToConsole();

            //with linq query syntax
            Console.WriteLine("Problem 5: With linq query sintax\n" + new string('_', 50));
            var ordered = from student in students
                          orderby student.FirstName, student.LastName descending
                          select student;
            ordered.PrintToConsole();
        }

        public static void Problem6()
        {
            Utilities.PrintDescription(Descriptions.Problem6);
            int[] numbers =
            {
                74, 37, 34, 75, 87, 35, 54, 97, 38, 83, 29, 0, 77, 84, 4, 84, 100, 36, 65, 20, 1, 61, 73, 37, 87, 79, 36,
                56, 89, 48, 9, 72, 30, 60, 27, 47, 16, 66, 9, 60, 80, 95, 59, 47, 27, 26, 1, 52, 61, 24, 44, 23, 9, 52,
                98, 37, 50, 6, 40, 22, 30, 75, 65, 13, 5, 90, 42, 17, 48, 8, 69, 41, 16, 58, 5, 93, 12, 6, 18, 87, 65,
                58, 69, 58, 19, 78, 98, 72, 30, 34, 5, 100, 98, 77, 88, 42, 33, 69, 36, 35
            };

            // Using Linq method syntax
            var divisibleBy5And7 = numbers.Where(n => (n % 7 == 0) && (n % 3 == 0));
            Console.WriteLine(
                $"From the numbers :\n{string.Join(", ", numbers)}\n theese are divisible by 5 and 7:\n{string.Join(", ", divisibleBy5And7)}");

            //using Linq query syntax

            divisibleBy5And7 = from number in numbers
                               where (number % 5 == 0) && (number % 3 == 0)
                               select number;
        }

        public static void Problem7()
        {
            Utilities.PrintDescription(Descriptions.Problem7);
            MyDelegateTimer.IntervalElapsedAction intervalMessage = () => Console.WriteLine("Interval Elapsed!");
            int interval = 3;
            MyDelegateTimer timer = new MyDelegateTimer(interval, intervalMessage);
            Thread t = new Thread(timer.Start);

            t.Start();
            Console.WriteLine($"Starting timer with interval between ticks {interval} sec.");

            int currentThreadPause = 12;
            Console.WriteLine($"Will wait for {currentThreadPause} sec, then will stop the timer");
            Thread.Sleep(currentThreadPause * 1000);
            timer.Stop();
            //t.Abort();
            Console.WriteLine("Timer stoped. At most 1 more message should be displayed.");
        }
        
        public static void Problem8()
        {
            Utilities.PrintDescription(Descriptions.Problem8);

            int interval = 3;
            MyEventTimer myEventTimer = new MyEventTimer {Interval = interval};

            Thread t = new Thread(myEventTimer.Start);

            TimerMessageService messageService = new TimerMessageService();
            myEventTimer.IntervalElapsed += messageService.OnIntervalElapsed;

            Console.WriteLine($"Starting timer with interval between events of {interval} sec");
            t.Start();
            int currentThreadPause = 12;

            Console.WriteLine($"Will wait for {currentThreadPause} sec, then will stop the timer");
            Thread.Sleep(currentThreadPause * 1000);
            myEventTimer.Stop();
            //t.Abort();
            Console.WriteLine("Timer stoped. At most 1 more message should be displayed.");
        }
        
        public static void Problem9()
        {
            Utilities.PrintDescription(Descriptions.Problem9);

            var allFromGroup2 = from student in students
                                where student.GroupNumber == 2
                                orderby student.FirstName
                                select student;

            allFromGroup2.PrintToConsole();
        }

        public static void Problem10()
        {
            Utilities.PrintDescription(Descriptions.Problem10);

            students.Where(s => s.GroupNumber == 2).OrderBy(s=>s.FirstName).PrintToConsole();
        }

        public static void Problem11()
        {
            //NOTE: will check for "jedi.org"
            Utilities.PrintDescription(Descriptions.Problem11);

            string searchTerm = "rebels.org";
            students.Where(s => Utilities.GetEmailDomain(s.Email).Equals(searchTerm)).PrintToConsole();
        }

        public static void Problem12()
        {
            Utilities.PrintDescription(Descriptions.Problem12);

            string searchCode = "02";
            students.Where(s => s.PhoneNumber.StartsWith(searchCode)).PrintToConsole();

            //alternative using query syntax
            var query = from student in students
                        where student.PhoneNumber.StartsWith(searchCode)
                        select student;
        }

        public static void Problem13()
        {
            //NOTE: I used 10 point based mark system so I will check for 10
            Utilities.PrintDescription(Descriptions.Problem13);

            double searchMark = 10;
            var excellentStudents = from student in students
                                    where student.Marks.Any(m => m == searchMark)
                                    select new
                                           {
                                               FullName = student.FirstName + " " + student.LastName,
                                               student.Marks
                                           };

            //alternative using method syntax
            var query =
                students.Where(s => s.Marks.Any(m => m == searchMark))
                        .Select(s => new {FullName = $"{s.FirstName} {s.LastName}", s.Marks});

            foreach (var student in excellentStudents)
            {
                Console.WriteLine(student.FullName);
                Console.WriteLine("Marks: " + string.Join(", ", student.Marks) + "\n");
            }
        }

        public static void Problem14()
        {
            Utilities.PrintDescription(Descriptions.Problem14);

            int searchMark = 2;
            var weakStudents =
                students.Where(s => s.Marks.Count(m => m == searchMark) == 2)
                        .Select(s => new
                                     {
                                         FullName = s.FirstName + " " + s.LastName,
                                         s.Marks
                                     });

            foreach (var student in weakStudents)
            {
                Console.WriteLine(student.FullName);
                Console.WriteLine("Marks: " + string.Join(", ", student.Marks) + "\n");
            }
        }

        public static void Problem15()
        {
            Utilities.PrintDescription(Descriptions.Problem15);

            string enrollmentYear = "2006";
            char firstDigit = enrollmentYear[2];
            char secondDigit = enrollmentYear[3];

            var studentsByYear = students.Where(s => (s.FN[4] == firstDigit) && (s.FN[5] == secondDigit));
            List<double> allMarks = new List<double>();
            foreach (Student student in studentsByYear)
            {
                Console.WriteLine($"Student: {student.FirstName} {student.LastName}");
                allMarks.AddRange(student.Marks);
            }
            Console.WriteLine($"Marks for the students enrolled in {enrollmentYear}");
            Console.WriteLine(string.Join(", ", allMarks));
        }

        public static void Problem17()
        {
            Utilities.PrintDescription(Descriptions.Problem17);
            string[] strings = { "I", "Am", "Sith", "Overlord" };

            var longest = strings.OrderByDescending(s => s.Length).First();
            Console.WriteLine($"Longest string from [{string.Join(", ",strings)}] is : {longest}");
            
        }

        public static void Problem18()
        {
            Utilities.PrintDescription(Descriptions.Problem18);

            var grouped = from student in students
                          group student by student.GroupNumber into g
                          select new {Group =  g.Key, Students = g.ToList()};

            Console.WriteLine("Printing students by group");
            foreach (var grouping in grouped)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Group: {grouping.Group}");
                Console.WriteLine($"Students:");
                Console.ResetColor();
                grouping.Students.PrintToConsole();
            }

        }
        
        public static void Problem19()
        {
            Utilities.PrintDescription(Descriptions.Problem19);

            var grouped = students.GroupBy(s => s.GroupNumber,
                                           s => s,
                                           (key, g) => new {Group = key, Students = g.ToList()});

            Console.WriteLine("Printing students by group");
            foreach (var grouping in grouped)
            {
                Console.ForegroundColor=ConsoleColor.DarkYellow;
                Console.WriteLine($"Group: {grouping.Group}");
                Console.WriteLine($"Students:");
                Console.ResetColor();
                grouping.Students.PrintToConsole();
            }
        }
    }
}