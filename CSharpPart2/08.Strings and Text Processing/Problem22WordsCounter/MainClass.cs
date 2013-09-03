/*
 * Telerik Academy  - Homework Solutions
 * Course    : C# Part II
 * Lecture  8: Strings and Text processing
 * Problem 22: Write a program that reads a string from the console and 
 *              lists all different words in the string along with information 
 *              how many times each word is found.
 */
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem22WordsCounter
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text here : ");
            string text = Console.ReadLine();

            var result = Regex.Matches(text, @"\w+").Cast<Match>()
                              .Select(m => m.Value.ToLower())
                              .GroupBy(w => w)
                              .Select(g => new { Word = g.Key, Count = g.Count() })
                              .ToList();
            Console.WriteLine("Theese are the words and their usage frequency : ");
            Console.WriteLine(new string('_', 30));
            result.ForEach(Console.WriteLine);
        }

    }
}
