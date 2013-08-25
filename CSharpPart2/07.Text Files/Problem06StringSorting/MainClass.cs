/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Text Files
 * Problem 6: Write a program that reads a text file containing a 
 *              list of strings, sorts them and saves them to another 
 *              text file. Example:
 *	            Ivan			George
 *	            Peter	--->	Ivan
 *	            Maria			Maria
 *	            George			Peter
 *
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace Problem06StringSorting
{
    class MainClass
    {
        static void Main()
        {
            string filePath = @"..\..\names.txt";
            
            List<string> lines = new List<string>();
            string line;
            using (StreamReader reader = new StreamReader(filePath))
            {
                while((line = reader.ReadLine())!=null)
                {
                    lines.Add(line);
                }
            }
            lines.Sort();
            using (StreamWriter writer = new StreamWriter(@"..\..\sotred.txt"))
            {
                foreach (var item in lines)
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}
