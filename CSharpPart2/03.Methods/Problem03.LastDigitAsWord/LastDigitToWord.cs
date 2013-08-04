/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 3: Methods
 * Problem 3: Write a method that returns the last digit of
 *              given integer as an English word. 
 *              Examples: 512  "two", 1024  "four", 12309  "nine".
 */

using System;
using System.Linq;

namespace Problem03.LastDigitAsWord
{
    class LastDigitToWord
    {
        enum Digits { Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine };
        static void Main()
        {
            int input = GetValidInput("Enter an integer : ");
            Console.WriteLine("The last digit is : {0}",ReturnLastDigitAsWord(input)); 
        }
        static string ReturnLastDigitAsWord(int number)
        {
            int digit = number % 10;
            return  Enum.GetName(typeof(Digits), digit);
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
