/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 12:Write a program that parses an URL address given in the format:
 *              [protocol]://[server]/[resource]
 *              and extracts from it the [protocol], [server] and [resource] 
 *              elements. For example from the URL http://www.devbg.org/forum/index.php 
 *              the following information should be extracted:
 *              [protocol] = "http"
 *              [server] = "www.devbg.org"
 *              [resource] = "/forum/index.php"
 */

//NOTE If you want to check the implementation, the actual work is done in the ParsUrl() method. 
using System;
using System.Collections.Generic;

namespace Problem12ParseURL
{
    class MainClass
    {
        static void Main()
        {
            // a collection of urls to test with. Add your own if you like
            string[] testCases =
            {
                "http://www.devbg.org/forum/index.php ",
                "ftp://ftp.funet.fi/pub/standards/RFC/rfc959.txt",
                "HTTP://EN.EXAMPLE.ORG/",
                "http://www.adobe.com/bg/products/photoshop.html",
                "https://www.dropbox.com/business?tk=house_ad&ag=teams&ad=house_ad_teams_v7&kw=",
                "your://own.test/case/here"
            };

            TestParseUrl(testCases);
        }
        private static Dictionary<string, string> ParseURL(string url)
        {
            Dictionary<string, string> urlInfo = new Dictionary<string, string>()
            {
                { "[protocol]", "" }, 
                { "[server]", "" }, 
                { "[resource]" , "" }
            };

            int firstBreak = url.IndexOf(':');
            int secondBreak = url.IndexOf("//");
            int thirdBreak = url.IndexOf('/', secondBreak+2);
            string protocol = url.Substring(0, firstBreak);
            string server = url.Substring(secondBreak + 2, thirdBreak-secondBreak-2 );
            string resourse = url.Substring(thirdBreak );

            urlInfo["[protocol]"] = protocol;
            urlInfo["[server]"] = server;
            urlInfo["[resource]"] = resourse;
            return urlInfo;
        }

        private static void TestParseUrl(string[] testCases)
        {
            int num = 1;
            foreach (var testCase in testCases)
            {
                Console.WriteLine("Test case {1} : {0}\n",testCase,num);
                foreach (var item in ParseURL(testCase))
                {
                    Console.WriteLine("{0} = '{1}'", item.Key, item.Value);
                }
                Console.WriteLine(new string('_',40));
                num++;
            }
        }
    }
}
