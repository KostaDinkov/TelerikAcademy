/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 4: Numeral Systems
 * Problem 3: Write a program to convert decimal 
 *              numbers to their hexadecimal representation.
 */

using System;

namespace Problem03.DecimalToHex
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("Enter an integer :");
            int decimalNumber = int.Parse(Console.ReadLine());
            string result = NumeralConvertions.DecimalToBase(decimalNumber, 16);
            Console.WriteLine("The number {0} represented as a hexadecimal value is {1} .", decimalNumber, result);
        }
    }
}
