/*
 * Lecture 6 : Loops
 * Problem 2 : Write a program that prints all 
 *              the numbers from 1 to N, that are 
 *              not divisible by 3 and 7 at the same time.
 */              


using System;

class AllNumbersToN
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
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i+";");
            }
        }
        Console.WriteLine();
    }
}

