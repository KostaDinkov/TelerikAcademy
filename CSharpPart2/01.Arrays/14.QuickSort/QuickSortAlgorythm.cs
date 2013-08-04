/*
 * Telerik Academy  - Homework Solutions
 * Course    : C# Part II
 * Lecture  1: Arrays
 * Problem 14: Write a program that sorts an array 
 *             of strings using the quick sort algorithm 
 *             (find it in Wikipedia).
 */             

using System;
using System.Linq;


class QuickSortAlgorythm
{
    static void Main(string[] args)
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

        //Call the sort method
        Quicksort(array, 0, array.Length - 1);
        
        //Print the result
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
    /// Implementation of the Quicksort algorythm
    /// </summary>
    static public void Quicksort(int[] elements, int left, int right)
    {
        int i = left, j = right;
        int pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                // Swap
                int tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }

        // Recursive calls
        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }
}

