/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Text Files
 * Problem 8: Write a program that replaces all occurrences of 
 *              the word "start" with the substring "finish" 
 *              in a text file. Ensure it will work with large files (e.g. 100 MB).
 */

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Problem08ReplaceWord
{
    class MainClass
    {
        static void Main()
        {
            string filePath = @"..\..\OriginalText.txt";

            string line;
            using (StreamReader reader = new StreamReader(filePath))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\replacedText.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        line = Regex.Replace(line, @"\bstart\b", "finish", RegexOptions.IgnoreCase);
                        writer.WriteLine(line);

                    }
                }

            }

        }

    }
}