/*
 * Lecture 6 : Loops
 * Problem 7 : Write a program that reads a number N and 
 *              calculates the sum of the first N members 
 *              of the sequence of Fibonacci: 
 *              0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 */              


using System;
using System.Collections.Generic;

class SumFibonacci
{
    static void Main()
    {
        uint sum = 0;
        int numCount = GetValidInput("Enter how many numbers of the \nFibonacci sequence to sumarize (positive int) :");
        if (numCount==1)
        {
            Console.WriteLine("The sum of the first {0} numbers in the Fibonacci sequence is 0",numCount);
            return;
        }
        List<uint> fibNums = GetFibNums(numCount);
        Console.WriteLine("The numbers Are : "+String.Join("; ",fibNums));
        foreach (uint number in fibNums)
        {
            sum += number;
        }
        Console.WriteLine("The sum of the first {0} numbers in the Fibonacci sequence is: " + sum,numCount);
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
    /// Returns an array of unsigned integers with the first n numbers of the
    /// Fibonacci sequence
    /// </summary>
    static List<uint> GetFibNums(int n)
    {
        List<uint> fibNums = new List<uint>();
        uint prevNum = 0;
        uint nextNum = 1;
        uint sum;
        fibNums.Add(prevNum);
        fibNums.Add(nextNum);

        for (int i = 0; i < n-2; i++)
        {
            sum = prevNum + nextNum;
            fibNums.Add(sum);
            prevNum = nextNum;
            nextNum = sum ;
     
        }
        return fibNums;
    }
}

