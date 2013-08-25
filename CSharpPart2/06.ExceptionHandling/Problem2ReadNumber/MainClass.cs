/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Exception Handling
 * Problem 2: Write a method ReadNumber(int start, int end) that enters an 
 *              integer number in given range [start…end]. If an invalid number 
 *              or non-number text is entered, the method should throw an exception. 
 *              Using this method write a program that enters 10 numbers: 
 *              a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */              

using System;

namespace Problem2ReadNumber
{
    class MainClass
    {
        static void Main()
        {
            int input;
            int start = 1;
            int end = 100;
            int numCount = 10;
            
            for (int i = 0; i < numCount; i++)
            {
                input = ReadNumber(start, end);
                start = input;
            }
        }
        static int ReadNumber(int start, int end)
        {
            int? result =null;
            bool inRange = false;
            while (result==null || inRange==false)
            {
                Console.WriteLine("Enter a number between {0} and {1}", start, end);
                try
                {
                    result = int.Parse(Console.ReadLine());
                    if (result < start || result > end)
                    {
                        inRange = false;
                        throw new ArgumentOutOfRangeException();
                    }
                    inRange = true;

                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Input not in range");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong input!");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("The input cannot be empty");
                }
                
            }
            return (int)result;
            
        }
    }
}
