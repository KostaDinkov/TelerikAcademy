/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Text Files
 * Problem 1: Write a program that reads a text file 
 *              and prints on the console its odd lines.
 */

using System;
using System.Text;
using System.IO;

namespace Problem01OddLines
{
    class MainClass
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\textfile1.txt",Encoding.GetEncoding("windows-1251"));
            int lineNumber = 1;
            string line = reader.ReadLine();
            while (line!=null)
            {
                if (lineNumber%2!=0)
                {
                    Console.WriteLine(line);
                }
                line = reader.ReadLine();
                lineNumber++;
                
            }
            reader.Dispose();
            

        }
       
    }
}
