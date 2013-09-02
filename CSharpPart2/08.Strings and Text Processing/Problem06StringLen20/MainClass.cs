/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 6: Write a program that reads from the console a string of 
 *              maximum 20 characters. If the length of the string is 
 *              less than 20, the rest of the characters should be filled 
 *              with '*'. Print the result string into the console.
 */
using System;

namespace Problem06StringLen20
{
    class MainClass
    {
        static void Main()
        {
            string input = GetStringInput("Enter a string of maximum 20 chars length:"); 
            string result = FillWithStar(input);
            Console.WriteLine(result);
        }
        static string FillWithStar( string input)
        {
            if (input.Length<20)
            {
                string fullStr = input + new string('*',20-input.Length);
                return fullStr;
            }
            else
                return input;
        }
        static string GetStringInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
    }
}
