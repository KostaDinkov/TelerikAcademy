/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 4: Numeral Systems
 * Problem 2: Write a program to convert 
 *              binary numbers to their decimal representation.
 */

using System;

namespace Problem02.BinaryToDecimal
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("Enter an integer :");
            string binaryNumber = Console.ReadLine();
            int result = NumeralConvertions.BaseToDecimal(binaryNumber, 2);
            Console.WriteLine("The number {0} represented as a decimal numeral value is {1} .", binaryNumber, result);
        }
    }
}
