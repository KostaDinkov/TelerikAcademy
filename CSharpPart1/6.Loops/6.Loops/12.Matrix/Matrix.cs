/*
 * Lecture 6 : Loops
 * Problem 11: Write a program that reads 
 *              from the console a positive 
 *              integer number N (N < 20) 
 *              and outputs a matrix like the following:
 */
using System;

class Matrix
{
    static void Main()
    {
        int size = GetValidInput("Enter the size of the matrix (positive int): ");

        for (int i = 0; i < size; i++)
        {
            int k = i + 1;
            for (int j = 0; j < size; j++)
            {
                Console.Write("[{0}]", k);
                k++;
            }
            Console.WriteLine();
        }
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

