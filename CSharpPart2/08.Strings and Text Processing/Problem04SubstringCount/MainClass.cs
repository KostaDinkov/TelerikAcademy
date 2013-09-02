/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 4: Write a program that finds how many times a substring 
 *              is contained in a given text (perform case insensitive search).	
 *              Example: 
 *              The target substring is "in". The text is as follows:
 *              We are living in an yellow submarine. We don't have anything else. 
 *              Inside the submarine is very tight. So we are drinking all the day. 
 *              We will move out of it in 5 days. 
 *              The result is: 9.
 */

using System;
using System.Text.RegularExpressions;

namespace Problem04SubstringCount
{
    class MainClass
    {
        static void Main()
        {
            string substring = "in";
            string testStr = @"We are living in an yellow submarine. 
                               We don't have anything else.Inside the 
                               submarine is very tight. So we are drinking 
                               all the day.We will move out of it in 5 days. ";
            
            int matchesCount = SubstringCount(testStr, substring);
            Console.WriteLine("Total matches found: {0}",matchesCount);
        }

        static int SubstringCount(string input, string substring)
        {
            int count = 0;
            MatchCollection matches = Regex.Matches(input, substring,RegexOptions.IgnoreCase);
            return matches.Count;
        }
    
    }
}
