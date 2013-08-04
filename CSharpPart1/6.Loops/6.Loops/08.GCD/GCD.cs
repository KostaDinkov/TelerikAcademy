/*
 * Lecture 6 : Loops
 * Problem 8 : Write a program that calculates the greatest 
 *              common divisor (GCD) of given two numbers. 
 *              Use the Euclidean algorithm (find it in Internet).
 */              


using System;

class GCD
{
    static void Main()
    {
        int numberA = GetValidInput("Enter number A : ");
        int numberB = GetValidInput("Enter number B : ");
        Console.WriteLine("The greatest common divisor of {0} and {1} is " + GCD(numberA, numberB), numberA, numberB);
    }
    /// <summary>
    /// Finds the GCD of two numbers.
    /// </summary>
    static int GCD(int a, int b)
    {
        int reminder;

        while (b != 0)
        {
            reminder = a % b;
            a = b;
            b = reminder;
        }

        return a;
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

