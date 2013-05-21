// Lecture 1: Intro to programming
// Problem 10: Provide a short list with information 
// about the most popular programming languages. How do they differ from C#?


//NOTE! I'm using a text file with the info provided 
//as required by the problrm specification
//relative path to the file :
//...\IntroToProgramming\10.C_Sharp_and_Other_Langs\bin\Debug\Popular_Languages_and_ C_Sharp.txt

using System;


class CSharpAndOtherLangs
{
    static void Main()
    {
        // get the path to the current directory and add to it the .txt file name
        string FilePath = Environment.CurrentDirectory + "\\Popular_Languages_and_ C_Sharp.txt";
        try
        {
            // try to open the .txt file and store its contents in a variable called text;
            // print the contents of text
            string text = System.IO.File.ReadAllText(FilePath);
            Console.Write(text);
        }
        catch (Exception)
        {
            // if the file cant be found ( or some other error occurs ) throw an exception
            Console.WriteLine("Sorry, the file 'Popular_Languages_and_ C_Sharp.txt' cannot be found...\n");
        }
  
    }
}

