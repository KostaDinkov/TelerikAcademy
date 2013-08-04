/*
* Telerik Academy  - Homework Solutions
* Course    : C# Part II
* Lecture  1: Arrays
* Problem 18: * Write a program that reads an array of integers 
 *              and removes from it a minimal number of elements 
 *              in such way that the remaining array is sorted 
 *              in increasing order. Print the remaining sorted 
 *              array. Example: 
 *              {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
 */

using System;
using System.Collections.Generic;
using System.Linq;

class RemoveSort
{
    static void Main()
    {
        //array constructor
        int arrCapacity = GetValidInput("Enter Array Capacity: ", 1, int.MaxValue);
        int[] array = new int[arrCapacity];
        Console.WriteLine("Enter the elements of the array, each on a new line :");
        for (int i = 0; i < arrCapacity; i++)
        {
            Console.Write("Element {0} :", i);
            array[i] = GetValidInput();
        }
        
        CheckForSortedSubarray(array);

    }
    /// <summary>
    /// Gets a valid int from the user 
    /// </summary>
    /// <param name="prompt">A string prompting for the input</param>
    /// <param name="lowerMargin">Lower margin for the valid input range</param>
    /// <param name="upperMargin">Upper margin for the valid input range</param>
    static int GetValidInput(string prompt = "", int lowerMargin = int.MinValue, int upperMargin = int.MaxValue)
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
    static void CheckForSortedSubarray(int[] arr)
    {
        
        List<int> longestSortedArray = new List<int>();
        for (int i = 1; i < Math.Pow(2, arr.Length); i++)       
        {
            //build a possible subarray
            List<int> subSet = new List<int>();
            for (int j = 0; j < arr.Length; j++)
            {
                if (((i >> j) & 1) * arr[j] != 0)
                {
                    subSet.Add(arr[j]);
                }
            }
            //check if conditions are met
            bool isSorted = false;
            
            for (int element = 0; element < subSet.Count-1; element++)
            {
                
                int nextElement = element+1;
                if (!(subSet[element] <= subSet[nextElement]))
                {
                    isSorted = false;
                    break;
                }
                else isSorted = true;
            }
            if (isSorted && longestSortedArray.Count<subSet.Count)
            {
                longestSortedArray = new List<int>(subSet);
            }
            subSet.Clear();            
        }
        Console.WriteLine("The biggest sorted subarray is of size {0}",longestSortedArray.Count);
        Console.WriteLine("Result array: ");
        foreach (var item in longestSortedArray)
        {
            Console.Write(item+"  ");
        }
        Console.WriteLine();
        
    }
}

