/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 16: Write a program that reads two dates in the format: 
 *              day.month.year and calculates the number of days between them. 
 *              Example:
 *              Enter the first date: 27.02.2006
 *              Enter the second date: 3.03.2004
 *              Distance: 4 days
 */
using System;
using System.Globalization;

namespace Problem16Days
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("Enter first date (dd.mm.yyyy) :");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd.mm.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter second date (dd.mm.yyyy) :");
            DateTime end = DateTime.ParseExact(Console.ReadLine(), "dd.mm.yyyy", CultureInfo.InvariantCulture);
            
            TimeSpan difference = (end - start);
            Console.WriteLine("The difference in days is : {0}",Math.Abs(difference.Days));
        }
    }
}
