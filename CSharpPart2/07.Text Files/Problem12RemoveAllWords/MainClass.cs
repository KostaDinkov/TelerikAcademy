/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Text Files
 * Problem 12: Write a program that removes from a text 
 *              file all words listed in given another text file. 
 *              Handle all possible exceptions in your methods.
 */

// NOTE: replacing the words wit "......" so that the result will be more visible
// Also done a little parsing for the words.txt file so that i can strip off some punctuation 
// Have gone a bit lazy on the exception handling... ;)

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Problem12RemoveAllWords
{
    class MainClass
    {
        static void Main()
        {
            string[] words = GetKeyWords(@"..\..\words.txt");
            if (words == null)
            {
                Console.WriteLine("The keywords file is either empty or not accessible");
                return;
            }
            string line;
            try
            {
                using (StreamReader inputText = new StreamReader(@"..\..\text.txt"))
                    using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
                    while ((line = inputText.ReadLine()) != null)
                    {
                        foreach (var word in words)
                        {
                            if (word != "")
                            {
                                line = Regex.Replace(line, "\\b" + word + "\\b", ".......", RegexOptions.IgnoreCase);
                            }
                        }
                        writer.WriteLine(line);
                    }
            }
            catch (IOException)
            {
                Console.WriteLine("Input file could not be reached");
                Console.WriteLine("Check the file path location and the length of the file path");
            }
            catch   (UnauthorizedAccessException)
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
            catch(System.IO.PathTooLongException)
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
