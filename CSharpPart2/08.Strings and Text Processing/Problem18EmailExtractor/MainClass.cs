/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 18: Write a program for extracting all email 
 *              addresses from given text. All substrings that 
 *              match the format <identifier>@<host>…<domain> 
 *              should be recognized as emails.
 */
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem18EmailExtractor
{
    class MainClass
    {
        static void Main()
        {
            string text = @"john@abv.bg, Here is some text containing emails such as 
                            gosho@somemail.com and another one like pesho@another.bz, 
                            and this one is shit@abv.bg and a more advanced Sv.nakov@tel.erik  John.Connor@195.250.101.219
                            and another stuff like me123@123.blabla.comerce";

            string pattern = @"(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)"+
                             @"(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$?";
            

            
            List<string> mails = new List<string>();
            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.Singleline|RegexOptions.IgnoreCase);
            foreach (Match match in matches)
            {
                mails.Add(match.Value);
            }
            Console.WriteLine("Results :");
            Console.WriteLine(new string('_',30));
            foreach (var mail in mails)
                Console.WriteLine(mail);
        }
    }
}
