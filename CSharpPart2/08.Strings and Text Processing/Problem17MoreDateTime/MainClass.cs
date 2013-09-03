/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 17: Write a program that reads a date and time given 
 *              in the format: day.month.year hour:minute:second 
 *              and prints the date and time after 6 hours and 30 
 *              minutes (in the same format) along with the day of 
 *              week in Bulgarian.
*/
using System;
using System.Globalization;

namespace Problem17MoreDateTime
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter  date (dd.MM.yyyy hh:mm:ss) :");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy hh:mm:ss", CultureInfo.CurrentCulture);
                Console.WriteLine(date.ToString("dd.MM.yyyy hh:mm:ss"));
                Console.WriteLine(date.ToString("dddd",CultureInfo.CreateSpecificCulture("bg-BG")));
            }
            catch (FormatException e)
            {
                Console.WriteLine("The date format is not correct");
            }
        }
    }
}
