/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 5: Objects and Classes
 * Problem 1: Write a program that reads a year from 
 *              the console and checks whether it is a leap. Use DateTime.
 */

using System;

namespace Problem01_IsLeap
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("Enter a random year :");
            int myYear = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(myYear))
            {
                Console.WriteLine("The year {0} is a leap year;", myYear);
            }
            else 
            {
                Console.WriteLine("The year {0} is NOT a leap year;", myYear);
                
            }
            
            
        }
    }
}
