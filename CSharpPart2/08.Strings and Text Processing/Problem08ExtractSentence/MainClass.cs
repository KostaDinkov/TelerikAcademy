/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 8: Write a program that extracts from a given text all 
 *              sentences containing given word.
 *              Example: The word is "in". The text is:
 *              We are living in a yellow submarine. We don't 
 *              have anything else. Inside the submarine is very tight. 
 *              So we are drinking all the day. We will move out of it in 5 days.
 *              The expected result is:
 *              We are living in a yellow submarine. We will move out of it in 5 days.
 *              Consider that the sentences are separated by "." and the words – 
 *              by non-letter symbols.
 */

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace Problem08ExtractSentence
{
    class MainClass
    {
        static void Main()
        {
            string filePath = @"..\..\sampletext.txt";
            string text = File.ReadAllText(filePath);
            string keyWord = "in";
            
            List<string> results = ExtractSentenceWithWord(text,keyWord);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

        }
        static List<string> ExtractSentenceWithWord(string input, string keyWord)
        {
            List<string> results = new List<string>();
            string[] sentences = input.Split('.');
            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence,"\\b"+keyWord+"\\b"))
                {
                    results.Add(sentence);
                }
            }
            return results;

        }
    }
}
