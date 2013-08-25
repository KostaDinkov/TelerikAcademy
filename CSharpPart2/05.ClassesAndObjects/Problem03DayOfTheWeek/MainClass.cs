/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 5: Objects and Classes
 * Problem 3: Write a program that prints 
 *          to the console which day of the week is today. 
 *          Use System.DateTime.
 */          

using System;

namespace Problem03DayOfTheWeek
{
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Now.DayOfWeek);     
        }
    }
}
