/*
 * Telerik Academy  - Homework Solutions
 * Course    : C# Part II
 * Lecture  8: Strings and Text processing
 * Problem 24: Write a program that reads a list of words, 
 *              separated by spaces and prints the list in an 
 *              alphabetical order.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem24SortWords
{
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("Enter some words separated by spaces");
            string input = Console.ReadLine();
            
            //the actual work
            List<string> wordsList = input.Split(' ').ToList();
            wordsList.Sort();
            
            Console.WriteLine("Here are the words sorted :");
            Console.WriteLine(new string('_',30));
            foreach (var word in wordsList)
            {
                Console.WriteLine(word);
            }
        }
    }
}
