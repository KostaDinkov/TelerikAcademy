/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 2: Write a program that reads a string, 
 *              reverses it and prints the result at the console.
 */
using System;
using System.Linq;

namespace Problem02ReverseString
{
    class MainClass
    {
        static void Main()
        {
            string usrInput = GetStringInput("Enter text: ");
            string reversed = ReverseString(usrInput);
            Console.WriteLine("The reversed input is : {0}",reversed);
        }
        static string ReverseString(string input)
        {
            char[] chars = new char[input.Length];
            int counter = 0;
            for (int index = input.Length-1; index >=0; index--,counter++)
            {
                chars[counter] = input[index];
            }
            return new string(chars);
        }
        static string GetStringInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
    }
    


}
