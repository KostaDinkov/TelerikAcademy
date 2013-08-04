/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 3: Methods
 * Problem 2: Write a method GetMax() with two parameters that 
 *              returns the bigger of two integers. Write a program 
 *              that reads 3 integers from the console and prints the 
 *              biggest of them using the method GetMax().
 */

using System;

namespace Problem02.GetMax
{
    class GetMaxNumber
    {
        static void Main()
        {
            int firstInt = GetValidInput("Enter the first integer: ");
            int secondInt = GetValidInput("Enter the second integer: ");
            int thirdInt = GetValidInput("Enter the third integer: ");
            Console.WriteLine("The biggest number is: {0}",GetMax(firstInt,(GetMax(secondInt,thirdInt))));

        }
        /// <summary>
        /// Returns the bigger of two integers.
        /// </summary>
        static int GetMax(int a, int b)
        {
            if (a>b)
            {
                return a;
            }
            return b;
        }
        /// <summary>
        /// Prompts for entering an integer of type int, in a specified range. Performs a check for validating the input.
        /// </summary>
        static int GetValidInput(string prompt = "", int lowerMargin = int.MinValue, int upperMargin = int.MaxValue)
        {
            bool isValid;
            int input;
            do
            {
                Console.Write(prompt);
                isValid = int.TryParse(Console.ReadLine(), out input);
                if (input < lowerMargin || input > upperMargin)
                {
                    isValid = false;
                }
            }
            while (isValid == false);
            return input;
        }
    }
}
