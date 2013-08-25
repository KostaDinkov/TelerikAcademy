/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Text Files
 * Problem 4: Write a program that compares two text files line 
 *              by line and prints the number of lines that are 
 *              the same and the number of lines that are different. 
 *              Assume the files have equal number of lines.
 */

using System;
using System.IO;

namespace Problem04EqualLines
{
    class MainClass
    {
        static void Main()
        {
            string lineA,lineB;
            int equal = 0;
            int notEqual = 0;

            using(StreamReader fileA = new StreamReader(@"..\..\textfileA.txt"))
            {
                using(StreamReader fileB = new StreamReader(@"..\..\textFileB.txt"))
                {
                    while ((lineA = fileA.ReadLine()) != null)
                    {
                        lineB = fileB.ReadLine();
                        if (lineA.Equals(lineB))
                        {
                            equal++;
                        }
                        else
                        {
                            notEqual++;
                        }

                    }
                    Console.WriteLine("Total lines in files - {0}", equal + notEqual);
                    Console.WriteLine("Equal lines - {0}", equal);
                    Console.WriteLine("Not equal lines - {0}", notEqual);       
                }
                
            }

        }
    }
}
