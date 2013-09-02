/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 11: Write a program that reads a number and prints it 
 *              as a decimal number, hexadecimal number, 
 *              percentage and in scientific notation. 
 *              Format the output aligned right in 15 symbols.
 */
using System;

namespace Problem11RepresentNumber
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("Enter a number : ");
            double input = double.Parse(Console.ReadLine());
            

            Console.WriteLine();
            Console.WriteLine("{0,15:D}".PadRight(15) + "As decimal",(int)input);
            Console.WriteLine("{0,15:X}".PadRight(15) + "As hexadecimal", (int)input);
            Console.WriteLine("{0,15:E}".PadRight(15) + "As scientific notation", input);
            Console.WriteLine("{0,15:P}".PadRight(15) + "As percentage", input);
            Console.WriteLine();
        }
    }
}
