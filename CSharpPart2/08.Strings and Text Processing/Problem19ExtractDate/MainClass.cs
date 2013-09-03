/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 19: Write a program that extracts from a given text all 
 *              dates that match the format DD.MM.YYYY. Display them 
 *              in the standard date format for Canada.
 */
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem19ExtractDate
{
    class MainClass
    {
        static void Main()
        {
            string text = @" 19.01.1999 Text with some dates like 12.12.2013 or like this one 01.01.1000, and this one is not valid 12.20.2013 this one too not valid
                             32.12.2012 and we will keep the year between 0 and 4 digits long so this is not valid 01.02.20001. I will go one step further 
                             and try to catch this 1.1.12 but not this 1.20.3333 this one yes - 12.1.681";

            List<DateTime> dates = new List<DateTime>();
            string pattern = @"\b(?<!\d.)[0,1]{0,1}[0-9]\.[0-1]{0,1}[0-9].\d{1,4}\b";
            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.Singleline);

            foreach (Match match  in matches)
            {
                dates.Add(DateTime.Parse(match.Value));

            }
            foreach (var date in dates)
            {
                Console.WriteLine(date.ToString("yyyy-MM-dd hh:mm:ss"));
            }
        }
    }
}
