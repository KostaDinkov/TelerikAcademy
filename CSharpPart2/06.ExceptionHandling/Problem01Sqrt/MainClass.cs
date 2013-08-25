/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Exception Handling
 * Problem 1: Write a program that reads an integer number 
 *              and calculates and prints its square root. 
 *              If the number is invalid or negative, print 
 *              "Invalid number". In all cases finally print 
 *              "Good bye". Use try-catch-finally.
 */

using System;

namespace Problem01Sqrt
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("Enter a  number to find its Square Root:");

            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0 )
                {
                    throw new ArgumentOutOfRangeException();
                    
                }
                Console.WriteLine("Result : {0} ", Math.Sqrt(number));
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Wrong input");
            }
            catch (ArgumentOutOfRangeException aore)
            {
                Console.WriteLine("Can not process negative numbers");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
