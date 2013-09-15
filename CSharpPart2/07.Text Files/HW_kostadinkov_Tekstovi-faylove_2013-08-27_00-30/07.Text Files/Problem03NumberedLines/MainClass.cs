/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Text Files
 * Problem 3: Write a program that reads a text file and inserts 
 *              line numbers in front of each of its lines. 
 *              The result should be written to another text file.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem03NumberedLines
{
    class MainClass
    {
        static void Main()
        {
            string line;
            int lineNum = 1;
            using (StreamWriter writer = new StreamWriter(@"..\..\NumberedLines.txt"))
            {
                using (StreamReader reader = new StreamReader(@"..\..\textfile1.txt"))
                {
                   
                    while ((line=reader.ReadLine()) != null)
                    {
                        writer.Write(lineNum + " ");
                        writer.WriteLine(line);
                        lineNum++;
                    }    
                }
                
            }
        }
    }
}
