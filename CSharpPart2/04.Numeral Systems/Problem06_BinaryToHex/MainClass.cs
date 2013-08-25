/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 4: Numeral Systems
 * Problem 6: Write a program to convert binary numbers 
 *              to hexadecimal numbers (directly).
 */

using System;

namespace Problem06_BinaryToHex
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("Enter a binary value : ");
            string binaryString = Console.ReadLine();
            string hexString = NumeralConvertions.BinaryStringToHex(binaryString);
            Console.WriteLine("The hexadecimal representation of {0}  is  {1}", binaryString, hexString);
        }
    }
}
