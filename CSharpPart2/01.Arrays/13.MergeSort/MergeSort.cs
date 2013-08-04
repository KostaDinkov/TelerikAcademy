/*
 * Telerik Academy  - Homework Solutions
 * Course    : C# Part II
 * Lecture  1: Arrays
 * Problem 13: Write a program that sorts an array of integers 
 *              using the merge sort algorithm (find it in Wikipedia).
 */

using System;
using System.Collections.Generic;

class MergeSortAlgorythm
{
    static void Main()
    {
        //array constructor
        int arrCapacity = GetValidInput("Enter Array Capacity: ");
        int[] array = new int[arrCapacity];
        Console.WriteLine("Enter the elements of the array, each on a new line :");
        for (int i = 0; i < arrCapacity; i++)
        {
            Console.Write("Element {0} :", i);
            array[i] = GetValidInput();
        }
        array = MergeSort(array);
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

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
    /// <summary>
    /// Implementation of a merge sort algorythm
    /// </summary>
    static int[] MergeSort( int[] a)
    {
        if (a.Length<=1)
        {
            return a;
        }
        int middle = a.Length / 2;
        int[] leftPart = new int[middle];
        for (int i = 0; i < middle; i++)
			{
                leftPart[i] = a[i];
			}
        int[] rightPart = new int[a.Length - middle];
        for (int i = 0; i < a.Length-middle; i++)
        {
            rightPart[i] = a[i + middle];
        }
        leftPart = MergeSort(leftPart);
        rightPart = MergeSort(rightPart);

        int left = 0;
        int right = 0;
        int[] sorted = new int[a.Length];
        for (int k = 0; k < a.Length; k++)
        {
            if (right == rightPart.Length ||((left<leftPart.Length)&&(leftPart[left]<=rightPart[right])))
            {
                sorted[k] = leftPart[left];
                left++;
            }
            else if (left == leftPart.Length || ((right < rightPart.Length)&& (rightPart[right]<=leftPart[left])))
            {
                sorted[k] = rightPart[right];
                right++;
            }
        }
        return sorted;
    }
    
}

