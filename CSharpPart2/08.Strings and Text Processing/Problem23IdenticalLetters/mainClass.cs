/*
 * Telerik Academy  - Homework Solutions
 * Course    : C# Part II
 * Lecture  8: Strings and Text processing
 * Problem 23: Write a program that reads a string from the console and 
 *          replaces all series of consecutive identical letters with a 
 *          single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem23IdenticalLetters
{
    class mainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text here : ");
            string text = Console.ReadLine();
            var result = Regex.Replace(text, @"(\w)\1+", m => m.Groups[1].ToString(), RegexOptions.Singleline|RegexOptions.IgnoreCase);
            Console.WriteLine("Result : {0}", result);
        }
    }
}
