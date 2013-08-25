/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 4: Numeral Systems
 * Problem 5: Write a program to convert hexadecimal 
 *              numbers to binary numbers (directly).
 */


using System;


namespace Problem05.HexToBinary
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("Enter a hexadecimal value : ");
            string hexString = Console.ReadLine();
            string binaryString = NumeralConvertions.HexStringToBinary(hexString);
            Console.WriteLine("The binary representation of {0}  is  {1}",hexString,binaryString);
        }
    }
}
