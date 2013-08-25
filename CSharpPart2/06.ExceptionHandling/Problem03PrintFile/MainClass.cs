/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Exception Handling
 * Problem 2: Write a program that enters file name along with its full file path 
 *              (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the 
 *              console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
 *              Be sure to catch all possible exceptions and print user-friendly error messages.
 */
using System;
using System.IO;

namespace Problem03PrintFile
{
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("Enter The full file path:");
            string filePath = Console.ReadLine();
            PrintFile(filePath);
        }

        static void PrintFile(string filePath)
        {
            Exception FileNotSupported = new Exception();
            string text ="";
            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException();
                }
                string extension = Path.GetExtension(filePath);
                if (extension!=".txt" || extension!=".ini" || extension!=".nfo")
                {
                    
                    throw new FileLoadException();
                }
                text = File.ReadAllText(filePath);
                Console.WriteLine(text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file {0} was not found : ", filePath);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The file name can not be empty");
            }
            catch(FileLoadException)
            {
                Console.WriteLine("File Type Not Supported!");
            }
            

        }
        
    }
}
