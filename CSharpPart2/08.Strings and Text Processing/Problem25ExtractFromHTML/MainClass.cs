/*
 * Telerik Academy  - Homework Solutions
 * Course    : C# Part II
 * Lecture  8: Strings and Text processing
 * Problem 25: Write a program that extracts from given HTML file 
 *              its title (if available), and its body text without the HTML tags. Example:
 */

//Note: Regex is not a good idea for parsing HTML code
//A better way is to use Html Agility Pack , found here :
//http://htmlagilitypack.codeplex.com/

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Problem25ExtractFromHTML
{
    class MainClass
    {
        static void Main()
        {
            string htmlCode = File.ReadAllText(@"..\..\htmlCode.txt");
            string title = Regex.Match(htmlCode, "(<title>)(.*?)(</title>)", RegexOptions.Singleline).Groups[2].ToString();
            string bodyCode = Regex.Match(htmlCode, @"(<body>)(.{1,}?)(</body>)",RegexOptions.Singleline).Groups[2].ToString();
            string bodyText = Regex.Replace(bodyCode, @"(<.+?>)", " ");
            Console.WriteLine("Title: {0}",title);
            Console.WriteLine("Body text :\n{0}",bodyText);
        }
    }
}
