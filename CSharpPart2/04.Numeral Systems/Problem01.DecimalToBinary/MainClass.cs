/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 4: Numeral Systems
 * Problem 1: Write a program to convert decimal
 *              numbers to their binary representation.
 */

using System;

namespace Problem01.DecimalToBinary
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("Enter an integer :");
            int decimalNumber = int.Parse(Console.ReadLine());
            string result = NumeralConvertions.DecimalToBase(decimalNumber, 2);
            Console.WriteLine("The number {0} represented as a binary value is {1} .",decimalNumber,result);
        }
    }
}
