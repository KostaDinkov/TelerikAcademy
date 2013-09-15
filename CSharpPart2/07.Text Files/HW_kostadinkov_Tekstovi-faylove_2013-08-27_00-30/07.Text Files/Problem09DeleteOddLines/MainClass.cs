/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Text Files
 * Problem 9: Write a program that deletes from given text 
 *              file all odd lines. The result should be in the same file.
 */
using System;
using System.Text;
using System.IO;
using System.Collections.Generic;


namespace Problem09DeleteOddLines
{
    class MainClass
    {
        static void Main()
        {
            string filepath = @"..\..\text.txt";
            string[] lines = File.ReadAllLines(filepath);
            List<string> oddLines = new List<string>();

            for (int index = 0; index < lines.Length; index++)
            {
                if (index%2!=0)
                {
                    oddLines.Add(lines[index]);
                }
            }
            File.WriteAllLines(filepath, oddLines);
        }
    }
}
