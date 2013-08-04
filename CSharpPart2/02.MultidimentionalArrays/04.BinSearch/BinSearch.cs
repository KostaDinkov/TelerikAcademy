/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 1: Multidimensional Arrays
 * Problem 4: Write a program, that reads from the console an 
 *              array of N integers and an integer K, sorts the 
 *              array and using the method Array.BinSearch() finds 
 *              the largest number in the array which is ≤ K. 
 */

using System;
using System.Linq;



class BinSearch
{
    static void Main()
    {
        int numberOfElements = GetValidInput("Enter the number of elements in the array: ", 1);
        int[] numbersArray = new int[numberOfElements];
        for (int i = 0; i < numberOfElements; i++)
        {
            Console.Write("Enter element {0} ",i );
            numbersArray[i] = GetValidInput("-> ");
        }
        int searchedFor = GetValidInput("Enter the  number the you are searching for: ");
        Console.WriteLine(  "Sorting the numbers...");
        Array.Sort(numbersArray);
        PrintArray(numbersArray);
        int searchedIndex = Array.BinarySearch(numbersArray, searchedFor);
        FindClosestSmallest(numbersArray, searchedIndex);

    }
    /// <summary>
    /// Prompts for entering an integer of type int, in a specified range. Performs a check for validating the input.
    /// </summary>
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
    static void PrintArray<T>( T[] array)
    {
        Console.WriteLine();
        foreach (var item in array)
        {
            Console.Write("[{0}] ",item );
        }
        Console.WriteLine();
    }
    static void FindClosestSmallest<T>(T[] array, int index)
    {
        if (index < 0)
        {
            // If the index is negative, it represents the bitwise 
            // complement of the next larger element in the array. 
            //
            index = ~index;
            Console.WriteLine();
            Console.WriteLine("Not found. The largest number that is smaller than the searched for number is: ");
            Console.WriteLine("-> "+ array[index-1]);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Found at index {0}.", index);
        }
    }
}
