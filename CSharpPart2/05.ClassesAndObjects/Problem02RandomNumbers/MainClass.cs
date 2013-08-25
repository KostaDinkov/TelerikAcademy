/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 5: Objects and Classes
 * Problem 2: Write a program that generates and 
 *              prints to the console 10 random values in the range [100, 200].
 */
using System;

namespace Problem02RandomNumbers
{
    class MainClass
    {
        static void Main()
        {
            Random rnd = new Random();
            int randomNumbersCount = 10;
            for (int i = 0; i < randomNumbersCount; i++)
            {
                Console.WriteLine(rnd.Next(100,201));
            }
        }
    }
}
