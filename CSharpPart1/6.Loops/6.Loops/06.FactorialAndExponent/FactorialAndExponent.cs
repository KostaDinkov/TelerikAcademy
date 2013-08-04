/*
 * Lecture 6 : Loops
 * Problem 6 : Write a program that, for a given two 
 *              integer numbers N and X, calculates the 
 *              sumS = 1 + 1!/X + 2!/X^N + … + N!/X^N
 */              

using System;

class FactorialAndExponent
{
    static void Main()
    {
        Console.WriteLine("Enter two positive integers.");
        int numberN = GetValidInput("Enter number N:" );
        int numberX = GetValidInput("Enter number X:");
        double sum = 1;
        for (int i = 1; i <=numberN; i++)
        {
            sum += (Factorial(i)/(Math.Pow(numberX, i)));
        }
        Console.WriteLine("Result: " + sum);
 
    }
    //a function to calculate the factorial of a given number
    static double Factorial(int number)
    {
        double result = 1;
        while (number > 0)
        {
            result *= number;
            number--;
        }
        return result;
    }
    // a function for getting a valid positive int from the user
    static int GetValidInput(string prompt)
    {
        bool isValidInput;
        int output;
        do
        {
            Console.Write(prompt);
            isValidInput = int.TryParse(Console.ReadLine(), out output);

        }
        while (!(isValidInput) || (output <= 1));
        return output;
    }
}


