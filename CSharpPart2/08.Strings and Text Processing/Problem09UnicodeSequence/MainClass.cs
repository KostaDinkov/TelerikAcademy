/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 10: Write a program that converts a string to a 
 *              sequence of C# Unicode character literals. 
 *              Use format strings. Sample input:
 *              Hi!
 *              Expected output:
 *              \u0048\u0069\u0021
 */
using System;
using System.Text;

namespace Problem09UnicodeSequence
{
    class MainClass
    {
        static void Main()
        {
            string inputStr = "Hi!";
            StringBuilder result = new StringBuilder();
            foreach (var symbol in inputStr)
            {
                result.Append(string.Format("\\u{0:x4}", (ushort)symbol));
            }
            Console.WriteLine(result.ToString());
        }
    }
}
