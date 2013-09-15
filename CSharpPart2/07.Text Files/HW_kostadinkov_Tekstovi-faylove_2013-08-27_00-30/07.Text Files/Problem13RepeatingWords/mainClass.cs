/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Text Files
 * Problem 13: Write a program that reads a list of words from a
 *              file words.txt and finds how many times each of the 
 *              words is contained in another file test.txt. The result 
 *              should be written in the file result.txt and the words 
 *              should be sorted by the number of their occurrences in 
 *              descending order. Handle all possible exceptions in your 
 *              methods.
 */

//NOTE: Cutting some corners with the exception handling 

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Problem13RepeatingWords
{
    class mainClass
    {
        static void Main()
        {
            //parse the key words to a string array
            string[] words = GetKeyWords(@"..\..\words.txt");
            if (words == null)
            {
                Console.WriteLine("The keywords file is either empty or not accessible");
            }
            
            //build a dictionary for the key words from the  words array
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (var word in words)
            {
                wordsCount.Add(word, 0);
            }
            
            string line;
            try
            {
                using (StreamReader inputText = new StreamReader(@"..\..\test.txt"))
                                    while ((line = inputText.ReadLine()) != null)
                    {
                        foreach (var word in words)
                        {
                            if (word != "" && line.Contains(word)) //if the current word from the dictionary is found in the current line...
                            {                                      //...being read, increase the value associated with the word
                                wordsCount[word] += 1;
                            }
                        }
                    }
                using (StreamWriter writer =new StreamWriter(@"..\..\result.txt"))
                {
                    foreach (var word in wordsCount)
                    {
                        writer.Write("The word '{0}' was found {1} times", word.Key, word.Value);
                        writer.WriteLine();
                        //also write on the console for quick check
                        Console.Write("The word '{0}' was found {1} times", word.Key, word.Value);
                        Console.WriteLine();
                    }
                }
                
            }
            catch (IOException)
            {
                Console.WriteLine("Input file could not be reached");
                Console.WriteLine("Check the file path location and the length of the file path");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You have no permission to write to that location");
            }
        }
        private static string[] GetKeyWords(string filepath)
        {
            try
            {
                string keyWords = File.ReadAllText(filepath);
                string[] words = keyWords.Split(' ');
                for (int word = 0; word < words.Length; word++)
                {
                    words[word] = Regex.Replace(words[word], @"\W", string.Empty);
                }
                return words;
            }
            catch (System.IO.PathTooLongException)
            {
                Console.WriteLine("The file path character length is exceeds the allowed limit.");

            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("The file was not found");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("Directory Not Found!");
            }

            return null;
        }
    }
}
