/*
 * Telerik Academy  - Homework Solutions
 * Course    : C# Part II
 * Lecture  8: Strings and Text processing
 * Problem 21: Write a program that reads a string from the console and prints all 
 *              different letters in the string along with information how many 
 *              times each letter is found. 
 */

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem21Letters
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text here : ");
            string text = Console.ReadLine();

            var result = Regex.Matches(text, @"\w").Cast<Match>()
                              .Select(m => m.Value.ToLower())
                              .GroupBy(l => l )
                              .Select(g=> new{Letter = g.Key, Count =g.Count()})
                              .ToList();
            Console.WriteLine("Theese are the letters and their use frequency : ");
            Console.WriteLine(new string('_',30));
            result.ForEach(Console.WriteLine);
        }
    }
}
