/*
 * Lecture 6 : Loops
 * Problem 13: * Write a program that calculates for given N 
 *               how many trailing zeros present at the end 
 *               of the number N!. Examples:
 *               N = 10  N! = 3628800  2
 *               N = 20  N! = 2432902008176640000  4
 *               Does your program work for N = 50 000?
 *               Hint: The trailing zeros in N! are equal to the 
 *               number of its prime divisors of value 5. Think why!
 */               


using System;

class TrailingZeros
{
    static void Main()
    {
        int number = GetValidInput("Enter a positive integer: ");
        ulong factNumber = Factorial(number);
        int zeroCount = numberOfTrailingZeros(factNumber);
        Console.WriteLine("Factorial of {0} is: " + factNumber, number);
        Console.WriteLine("Number of trailing zeros: " + zeroCount);
    }
    /// <summary>
    /// Returns the number of trailing zeros in an integer 
    /// </summary>
    static int numberOfTrailingZeros(ulong num)
    {
        if (num == 0)
            return 1;
        int i = 0;
        while (num % 10 == 0)
        {
            num = num / 10;
            i++;
        }
        return i;
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
    /// <summary>
    /// Returns the factorial of a number
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
}
