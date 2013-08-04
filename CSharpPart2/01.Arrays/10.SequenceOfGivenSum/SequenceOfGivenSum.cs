/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 1: Arrays
 * Problem 10: Write a program that finds in given 
 *              array of integers a sequence of 
 *              given sum S (if present). 
 *              Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
 *
 */
using System;
using System.Collections.Generic;

class SequenceOfGivenSum
{
    static void Main()
    {
        int S = GetValidInput("Enter the sum to be searched for: ");
        //array constructor
        int arrCapacity = GetValidInput("Enter Array Capacity: ");
        int[] array = new int[arrCapacity];
        Console.WriteLine("Enter the elements of the array, each on a new line :");
        for (int i = 0; i < arrCapacity; i++)
        {
            Console.Write("Element {0} :", i);
            array[i] = GetValidInput();
        }

        FindSum(S, array);// a helper function that does all the work . See inplementation below.
    }
    /// <summary>
    /// Searches for a sum of a sub sequence in a given array
    /// </summary>
    static void FindSum(int sum, int[] input )
    {
        for (int i = 0; i < input.Length; i++)
        {
            List<int> resultSequence = new List<int>();
            int currentSum = 0;
            for (int j = i; j < input.Length; j++)
            {
                resultSequence.Add(input[j]);
                currentSum += input[j];
                if (currentSum == sum)
                {
                    Console.WriteLine("Sum Found!" );
                    Console.Write("Result Sequence -> ");
                    Console.Write("[ ");
                    foreach (var item in resultSequence)
                    {
                        Console.Write(item+" ");
                    }
                    Console.WriteLine("]");
                    return; 
                }
            }
        }
        Console.WriteLine("Sum Not Found!");
        return;
    }
    /// <summary>
    /// Gets a valid int from the user 
    /// </summary>
    /// <param name="prompt">A string prompting for the input</param>
    /// <param name="lowerMargin">Lower margin for the valid input range</param>
    /// <param name="upperMargin">Upper margin for the valid input range</param>
    static int GetValidInput(string prompt = "", int lowerMargin = 1, int upperMargin = int.MaxValue)
    {
        bool isValid;
        int input;
        do
        {
            Console.Write(prompt);
            isValid = int.TryParse(Console.ReadLine(), out input);
            if (input < lowerMargin || input > upperMargin)
            {
                isValid = false;
            }
        }
        while (isValid == false);
        return input;
    }
}

