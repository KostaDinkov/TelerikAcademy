/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 15: Write a program that replaces in a HTML document given as 
 *              string all the tags <a href="…">…</a> with corresponding 
 *              tags [URL=…]…/URL]. Sample HTML fragment:
 *              <p>Please visit <a href="http://academy.telerik. com">
 *              our site</a> to choose a training course. Also visit 
 *              <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
 *              Becomes:
 *              <p>Please visit [URL=http://academy.telerik. com]our site[/URL] 
 *              to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 */
using System;
using System.IO;

namespace Problem15HtmlTag
{
    class MainClass
    {
        static void Main()
        {
            string htmlCode = File.ReadAllText(@"..\..\htmlpage.html");
            string pattern = "(<a href=)(\")(.+?)(\")(>).+?(</a>)";
            string result = htmlCode.Replace("<a href=\"", "[URL=")
                                    .Replace("<a href =\"", "[URL=")
                                    .Replace("<a href = \"", "[URL=")
                                    .Replace("</a>", "[/URL]")
                                    .Replace("\">", "]");
            
            Console.WriteLine(result);
            
        }
    }
}
