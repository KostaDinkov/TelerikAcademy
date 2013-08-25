/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 4: Numeral Systems
 * Problem 4: Write a program to convert 
 *              hexadecimal numbers to their decimal representation.
 */

using System;


namespace Problem04.HexToDecimal
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer :");
            string hexNumber = Console.ReadLine();
            hexNumber =  hexNumber.ToUpper();
            int result = NumeralConvertions.BaseToDecimal(hexNumber, 16);
            Console.WriteLine("The number {0} represented as a decimal numeral value is {1} .", hexNumber, result);
        }
    }
}
