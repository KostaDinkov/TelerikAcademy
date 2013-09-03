/*
 * Telerik Academy  - Homework Solutions
 * Course    : C# Part II
 * Lecture  8: Strings and Text processing
 * Problem 20: Write a program that extracts from a 
 *              given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem20Palindromes
{
    class MainClass
    {
        static void Main()
        {
            string text= "ABBA, lamal, exe, boob, non, some, nice words here too";

            var result = Regex.Matches(text, @"\w+").Cast<Match>() 
                              .Select(m => m.Value.ToLower()) 
                              .Where(w => String.Join("", w.Reverse()) == w) 
                              .ToList();
            result.ForEach(Console.WriteLine);
        }
    }
}
