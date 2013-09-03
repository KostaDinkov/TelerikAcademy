/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 13: Write a program that reverses the words in given sentence.
 *              Example: 
 *              "C# is not C++, not PHP and not Delphi!"  
 *              "Delphi not and PHP, not C++ not is C#!".
 */

//The biggest challenge was to preserve the position of the punctuation.
//Only removing the punctuation which appears directly after a word.  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem13ReverseWords
{
    class MainClass
    {
        static void Main()
        {
            string[] testStrings =
            {
                "C# is not C++, not PHP and not Delphi!",
                "Some more text, separated by, some commas.",
                "Heavy. Punctuation, Here? How! to: remove?"
            };

            foreach (var str in testStrings)
            {
                Console.WriteLine("Original : {0}",str);
                Console.WriteLine("Result : {0}",ReverseWords(str));
                Console.WriteLine(new string('_',30));
            }
            
        }
        private static string ReverseWords(string input)
        {
            // Split the string into words, separated by blank space
            string[] words = input.Split(' ');

            //check if a word ends with punctuation and if so, add the punctuation...
            //... to a dictionary, preserving its original position in the text...
            //then remove the punct char from the word
            Dictionary<int, char> punct = new Dictionary<int, char>();
            for (int index = 0; index < words.Length; index++)
            {
                if (@",.!?:".Contains(words[index][words[index].Length - 1]))
                {
                    punct.Add(index, words[index][words[index].Length - 1]);
                    words[index] = words[index].Remove(words[index].Length - 1);
                }
            }

            List<string> result = new List<string>();

            //append the words and punctuation in the correct order
            int wordsIndex = words.Length - 1;
            for (int index = 0; index < words.Length + punct.Count; index++)
            {

                if (punct.ContainsKey(index - 1))
                {
                    result.Add((punct[index - 1]).ToString());
                }
                if (wordsIndex >= 0)
                {
                    result.Add(words[wordsIndex]);
                    wordsIndex--;
                }

            }
            //create a string with spaces at the correct positions
            StringBuilder resultStr = new StringBuilder();
            foreach (var item in result)
            {
                if (!@",.!?:".Contains(item))
                {
                    resultStr.Append(item);
                    resultStr.Append(" ");
                }
                else
                {
                    resultStr.Remove(resultStr.Length - 1, 1);
                    resultStr.Append(item);
                    resultStr.Append(" ");
                }
            }
            return resultStr.ToString();
            
        }
    }
}
