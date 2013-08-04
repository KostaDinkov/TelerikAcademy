/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 1: Arrays
 * Problem 8: Write a program that finds the sequence of maximal
 *              sum in given array. Example:
 *	            {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
 *	            Can you do it with only one loop (with single scan 
 *              through the elements of the array)?
 *
 */

//NOTE: I'll be usilng the Kadane's algorithm
using System;
using System.Collections.Generic;
using System.Linq;

class MaxSubbarray
{
    static void Main()
    {   // build the input array
        int arrCapacity = GetValidInput("Enter Array Capacity: ");
        int[] array = new int[arrCapacity];
        Console.WriteLine("Enter the elements of the array, each on a new line :");
        for (int i = 0; i < arrCapacity; i++)
        {
            Console.Write("Element {0} :", i);
            array[i] = GetValidInput();

        }
        //do the math
        List<int> result = new List<int>();
        result = MaxSubarraySum(array);
        //TODO remove self anihilating pairs at the start or at the end of the result array
        //for (int i = 0; i < result.Count; i++)
        //{
        //    if (result[0]+result[1]==0)
        //    {
        //        result.Remove(result[0]);
        //        result.Remove(result[1]);
        //    }
        //    if (result[result.Count-1]+result[result.Count-2]==0)
        //    {
        //        result.Remove(result[result.Count - 1]);
        //        result.Remove(result[result.Count - 1]);
        //    }
        //}
        // format the output
        Console.WriteLine("The sequence with largest sum is");
        Console.Write("[");
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i]);
            Console.Write(" ");
        }
        Console.WriteLine("]");
        Console.WriteLine("Sum : "+ result.Sum());
    }
    /// <summary>
    /// Returns the sequence with greatest sum in an int array
    /// </summary>
    static List<int> MaxSubarraySum( int[] input)
    {
        List<int> result = new List<int>();
        int maxSoFar = input[0];
        int maxEndingHere = input[0];
        int begin = 0;
        int beginTmp = 0;
        int end = 0;

        for (int i = 1; i < input.Length; i++)
        {
            // calculate maxEndingHere
            if (maxEndingHere<0)
            {
                maxEndingHere = input[i];
                beginTmp = i;
            }
            else
            {
                maxEndingHere += input[i];
            }
            //calculate maxSoFar
            if (maxEndingHere>=maxSoFar)
            {
                maxSoFar = maxEndingHere;
                begin = beginTmp;
                end = i;
            }


        }
        // format the output

        //result.Add(maxSoFar);
        for (int i = begin; i <= end; i++)
			{
			    result.Add(input[i]);
			}
        return result;
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

