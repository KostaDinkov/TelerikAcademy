/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 1: Arrays
 * Problem 9: Write a program that finds the most frequent 
 *              number in an array. Example:
 *	            {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;

class ArrayMode
{
    static void Main()
    {
        int arrCapacity = GetValidInput("Enter Array Capacity: ");
        int[] array = new int[arrCapacity];
        Console.WriteLine("Enter the elements of the array, each on a new line :");
        for (int i = 0; i < arrCapacity; i++)
        {
            Console.Write("Element {0} :", i);
            array[i] = GetValidInput();

        }
        Console.WriteLine(GetMode(array));
    }
    static string GetMode(int[] input)
    {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach (var number in input)
        {
            if (dict.ContainsKey(number))
            {
                dict[number] += 1;
            }
            else
            {
                dict.Add(number, 1);
            }
            
        }
        var maxKey = dict.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        int maxValue = dict.Values.Max();
        string result = "The mode of the sequence is " + maxKey.ToString()+" - ("+maxValue.ToString()+" times)"  ;
        return result;
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

