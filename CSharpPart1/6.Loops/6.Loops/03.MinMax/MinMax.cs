/*
 * Lecture 6 : Loops
 * Problem 3 : Write a program that reads from the 
 *              console a sequence of N integer numbers 
 *              and returns the minimal and maximal of them.
 */


using System;
using System.Linq;

class MinMax
{
    static void Main()
    {
        int number;
        bool isValidInput;
        do
        {
            Console.Write("Enter a  the lenght of the number sequence : ");
            isValidInput = int.TryParse(Console.ReadLine(), out number);
        }
        while (!(isValidInput) || (number <= 0));
        int[] numSequence = new int[number];
        Console.WriteLine("Enter {0} numbers, each on a new line", number);
        for (int i = 0; i < number; i++)
        {
            numSequence[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The greatest value is : " + numSequence.Max());
        Console.WriteLine("The smallest value is : " + numSequence.Min());
    }
}

