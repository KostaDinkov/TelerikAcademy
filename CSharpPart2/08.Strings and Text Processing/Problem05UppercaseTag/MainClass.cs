/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 5: You are given a text. Write a program that changes the text in all 
 *              regions surrounded by the tags <upcase> and </upcase> to uppercase. 
 *              The tags cannot be nested. Example:
 *              We are living in a <upcase>yellow submarine</upcase>. 
 *              We don't have <upcase>anything</upcase> else.
 *              The expected result:
 *              We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */

//Note: Really proud of this one

using System;
using System.Text.RegularExpressions;
using System.IO;

namespace Problem05UppercaseTag
{
    class MainClass
    {
        static void Main()
        {
            string textSample = File.ReadAllText(@"..\..\sampleText.txt");
            string pattern = "<upcase>(.*?)</upcase>";
            Console.WriteLine(Regex.Replace(textSample, pattern, m => m.Groups[1].ToString().ToUpper(),RegexOptions.Singleline)); 
        }
    }
}
