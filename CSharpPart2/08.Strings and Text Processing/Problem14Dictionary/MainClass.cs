/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 14: A dictionary is stored as a sequence of text lines 
 *              containing words and their explanations. Write a 
 *              program that enters a word and translates it by 
 *              using the dictionary. Sample dictionary:
 *              .NET – platform for applications from Microsoft 
 *              CLR – managed execution environment for .NET
 *              namespace – hierarchical organization of classes
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem14Dictionary
{
    class MainClass
    {
        static void Main()
        {
            
            Console.Write("Enter a word to search the dictionary for (case insensitive) :");
            string key = Console.ReadLine();
            string dictPath = @"..\..\dictionary.txt";
            Dictionary<string,string> dict = BuildDict(dictPath);
            string result = FindDescription(key, dict);
            Console.WriteLine(result);
        }

        private static Dictionary<string,string> BuildDict(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (var line in lines)
            {
                string separators = "–-:";
                foreach (var sep in separators)
                {
                    int separatorIndex = line.IndexOf(sep);
                    if (separatorIndex!=-1)
                    {
                        string key = line.Substring(0, separatorIndex - 1).ToLower();
                        string value = line.Substring(separatorIndex + 1);
                        dict.Add(key, value);
                    }
                }
                
            }
            return dict;
        }
        static string FindDescription(string key, Dictionary<string, string> dict)
        {
            string result;
            if (dict.Keys.Contains(key.ToLower()))
            {

                return result = string.Format("Result :\n{0} - {1}", key, dict[key.ToLower()]);
            }
            else
            {
                return "Enry not found!";
            }
        }

        
    }
}
