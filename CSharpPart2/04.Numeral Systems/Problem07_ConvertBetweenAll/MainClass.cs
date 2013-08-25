/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 4: Numeral Systems
 * Problem 7: Write a program to convert from any numeral 
 *              system of given base s to any other numeral 
 *              system of base d (2 ≤ s, d ≤  16).
 */

using System;


namespace Problem07_ConvertBetweenAll
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("Enter the base of the numeral system you wish to convert FROM :");
            int sourceBase = int.Parse(Console.ReadLine());
            Console.Write("Enter the base of the numeral system you wish to convert TO :");
            int resultBase = int.Parse(Console.ReadLine());
	        
            Console.Write("Enter the value to be converted :");
            string stringInput = Console.ReadLine();
            stringInput = stringInput.ToUpper();
            int sourceToDecimal = NumeralConvertions.BaseToDecimal(stringInput, sourceBase);
            string stringResult = NumeralConvertions.DecimalToBase(sourceToDecimal, resultBase);
            Console.WriteLine("The result is :{0}", stringResult);
            
        }
    }
}
