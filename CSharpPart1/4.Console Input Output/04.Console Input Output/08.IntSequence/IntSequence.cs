/*
 * Lecture 4 : Console Input Output
 * Problem 8 : Write a program that reads an integer number n 
 *              from the console and prints all the numbers in 
 *              the interval [1..n], each on a single line.
 */              


using System;

class IntSequence
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int inputN = int.Parse(Console.ReadLine());
        int startNum = 1;
        if (inputN > 0) //if the input is a positive int...
        {
            Console.WriteLine(startNum);
            for (int i = 0; i < inputN-1; i++)
            {
                startNum += 1;
                Console.WriteLine(startNum);  
            }
        }
        else if (inputN < 0)// if the input is a negative int...
        {
            Console.WriteLine(startNum);
            for (int i = 0; i > inputN-1; i--)
            {
                startNum -= 1;
                Console.WriteLine(startNum); 

            }
        }
    }
}

