/*
 * Lecture 6 : Loops
 * Problem 10: Write a program to calculate 
 *              the Nth Catalan number by given N.
 */              
using System;

class CatalanNumbers
{
    static void Main()
    {
        int number = GetValidInput("Enter the Nth catalan number you wish to display : ");
        ulong catalanNum = (ulong)(Factorial(2 * number) / (Factorial(number + 1) * Factorial(number)));
        Console.WriteLine("The {0}th catalan number is: " + catalanNum,number);

    }
    /// <summary>
    ///Returns the factorial of a number
    /// </summary>    
    static ulong Factorial(int number)
    {
        ulong result = 1;
        while (number > 0)
        {
            result *= (ulong)number;
            number--;
        }
        return result;
    }
    /// <summary>
    /// Gets a positive integer from the console
    /// </summary>
    static int GetValidInput(string prompt)
    {
        bool isValidInput;
        int output;
        do
        {
            Console.Write(prompt);
            isValidInput = int.TryParse(Console.ReadLine(), out output);
        }
        while (!(isValidInput) || (output <= 0));
        return output;
    }
}

