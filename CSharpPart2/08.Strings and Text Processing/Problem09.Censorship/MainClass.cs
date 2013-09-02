/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 9: We are given a string containing a list of forbidden words and a 
 *              text containing some of these words. Write a program that replaces 
 *              the forbidden words with asterisks. Example:
 *              Microsoft announced its next generation PHP compiler today. 
 *              It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
 *              Words: "PHP, CLR, Microsoft"
 *              The expected result:
 *              ********* announced its next generation *** compiler today. 
 *              It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
 */

//NOTE : Even though it was not explicitly demanded, I also ignore the case of the words to be censored.

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Problem09.Censorship
{
    class MainClass
    {
        static void Main()
        {
            string filePath = @"..\..\sampletext.txt";
            string text = File.ReadAllText(filePath);
            string words = "PHP, CLR, Microsoft";
            string result = CensorText(text, words);

            Console.WriteLine(result);
        }
  
        private static string CensorText(string text, string words)
        {
            string result = text;                               
            string keyWords = words.Replace(",",string.Empty);
            string[] wordsArr = keyWords.Split(' ');
            foreach (var word in wordsArr)
            {
                string pattern = "\\b" + word + "\\b";
                string censorStr = new string('*',word.Length);
                result = Regex.Replace(result, pattern, censorStr,RegexOptions.IgnoreCase);
            }
            return result;
        }
        
    }
}
