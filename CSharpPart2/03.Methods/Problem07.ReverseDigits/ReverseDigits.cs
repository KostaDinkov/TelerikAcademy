/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 3: Methods
 * Problem 7: Write a method that reverses the
 *              digits of given decimal number. Example: 256  652
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem07.ReverseDigits
{
    class ReverseDigits
    {
        static void Main()
        {
            int number = GetValidInput("Enter an integer : ");
            Console.WriteLine(ReverseDigitsOfNumber(number));
        }
        static int ReverseDigitsOfNumber( int number)
        {
            return number.ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0');
        }
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
