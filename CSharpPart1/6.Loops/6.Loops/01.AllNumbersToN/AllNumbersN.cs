/*
 * Lecture 6: Loops
 * Problem 1: Write a program that prints all the numbers from 1 to N.
 */

using System;

class AllNumbersN
{
    static void Main()
    {
        int number;
        bool isValidInput;
        do
        {
            Console.Write("Enter a  positive integer : ");
            isValidInput = int.TryParse(Console.ReadLine(), out number);
        }
        while (!(isValidInput) || (number <= 0));

        for (int i = 1; i <= number; i++)
        {
            Console.Write(i+",");
        }
        Console.WriteLine();
    }
}

