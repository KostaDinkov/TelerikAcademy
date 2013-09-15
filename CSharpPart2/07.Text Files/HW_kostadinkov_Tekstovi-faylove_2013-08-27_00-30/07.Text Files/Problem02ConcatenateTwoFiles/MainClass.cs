/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Text Files
 * Problem 2: Write a program that concatenates 
 *              two text files into another text file.
 */

using System;
using System.IO;

namespace Problem02ConcatenateTwoFiles
{
    class MainClass
    {
        static void Main()
        {
            string file1, file2;
            using(StreamReader reader = new StreamReader(@"..\..\textFile1.txt"))
            {
                file1 = reader.ReadToEnd();
            }
            using (StreamReader reader = new StreamReader(@"..\..\textFile2.txt"))
            {
                file2 = reader.ReadToEnd();
            }
            
            using(StreamWriter writer = new StreamWriter(@"..\..\ConcatenatedFile.txt"))
            {
                writer.Write(file1);
                writer.Write(file2);
            }
        }
    }
}
