/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 1: Describe the strings in C#. What is typical for the string 
 *              data type? Describe the most important methods of the String class.
 */

using System;
using System.IO;

namespace Problem01StringClassDescription
{
    class MainClass
    {
        static void Main()
        {
            string text = File.ReadAllText(@"..\..\description.txt");
            Console.WriteLine(text);
        }
    }
}
