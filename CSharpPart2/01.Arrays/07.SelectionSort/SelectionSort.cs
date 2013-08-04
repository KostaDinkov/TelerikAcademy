/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 1: Arrays
 * Problem 7: Sorting an array means to arrange its elements 
 *              in increasing order. Write a program to sort 
 *              an array. Use the "selection sort" algorithm: 
 *              Find the smallest element, move it at the first 
 *              position, find the smallest from the rest, 
 *              move it at the second position, etc.
 */

//Note: I'll be using a list instead of array for the input...
//...so that i can remove the smallest value from it after adding it...
//...to another list
using System;
using System.Collections.Generic;

class SelectionSort
{
    static void Main()
    {
        int arrCapacity = GetValidInput("Enter array capacity: ");
        List<int> array = new List<int>();
        for (int i = 0; i < arrCapacity; i++)
        {
            Console.Write("Element {0} :", i);
            array.Add(int.Parse(Console.ReadLine()));
        }
        List<int> sorted = new List<int>();
        sorted = Sort(array);
        Console.WriteLine("The sorted list is:");
        Console.Write("[");
        foreach (var item in sorted)
        {
            Console.Write(item);
            Console.Write(" ");
        }
        Console.WriteLine("]");

    }
    static List<int> Sort( List<int> input )
    {
        List<int> sortedList = new List<int>();
        
        while (input.Count>0)
        {
            int smallest = input[0];
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]<smallest)
                {
                    smallest = input[i];
                }
            }
            sortedList.Add(smallest);
            input.Remove(smallest);
        }
        return sortedList;

    }
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

