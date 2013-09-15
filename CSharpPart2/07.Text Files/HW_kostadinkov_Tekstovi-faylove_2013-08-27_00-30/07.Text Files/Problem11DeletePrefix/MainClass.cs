/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Text Files
 * Problem 11: Write a program that deletes from a text file all words 
 *              that start with the prefix "test". Words contain only 
 *              the symbols 0...9, a...z, A…Z, _.
 */

//Note : assuming that the description means all USED words "contain only the symbols 0...9, a...z, A…Z "
//therefore excluding checks for the following cases : "word" word, word! wo!@#rd !@#word!@# ...and so on

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Problem11DeleteWordByPrefix
{
    class MainClass
    {
        static void Main()
        {
            string filePath = @"..\..\input.txt";
            string removeString = "test";
            string line;
            
            using (StreamReader reader = new StreamReader(filePath))
            {
                while ((line=reader.ReadLine())!=null)
                {
                    Console.WriteLine("original line:\n{0}",line);
                    Console.WriteLine("Result line:\n{0}",Regex.Replace(line, @"\btest\w+",string.Empty,RegexOptions.IgnoreCase));
                }
                
            }
        }

    }
}
