// Lecture 1: Intro to programming
// Problem 11: Describe the difference between C# and .NET Framework.

//NOTE! I'm using a text file with the info provided, 
//as required by the problem specification
//relative path to the file :
//...\IntroToProgramming\11.C_Sharp_And_Dot_Net\bin\Debug\CSharpAndDotNet.txt

using System;
using System.IO;

class CSharpAndDotNet
{
    static void Main()
    {
        try
        {
            // get the path to the current directory and add to it the .txt file name
            string FilePath = Environment.CurrentDirectory + "\\CSharpAndDotNet.txt";

            // try to open the .txt file and store its contents in a variable called text;
            // print the contents of text            
            string text = File.ReadAllText(FilePath);
            Console.WriteLine(text);
        }
        catch (Exception)
        {
            //If something goes wrong, throw an exception
            Console.WriteLine("There was an error executing the programm");
        }
    }
}

