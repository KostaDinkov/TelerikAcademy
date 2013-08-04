/*
* Telerik Academy  - Homework Solutions
* Course    : C# Part II
* Lecture  1: Arrays
* Problem 21: Write a program that reads two numbers N and K 
*              and generates all the combinations of K distinct 
*              elements from the set [1..N]. Example:
*              N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
*/              

using System;
using System.Collections.Generic;
using System.Linq;
using Combinatorics.Collections;

//NOTE: Using a Combinatorics library for problems 19,20,21 (  gets the job done pretty well )
//http://www.codeproject.com/Articles/26050/Permutations-Combinations-and-Variations-using-C-G

class Combinations
{
    static void Main()
    {
        int n = GetValidInput("Enter the upper margin for the number list ( 1 to N ): ", 2);
        //build the array
        List<int> numbers = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }
        //get the number of ellements to be combined
        int k = GetValidInput("Enter the number of elements to ne combined :", 1);
        //generate a combinations collection
        Combinations<int> combinations = new Combinations<int>(numbers, k);
        //print the elements in the collection
        foreach (IList<int> p in combinations)
        {
            foreach (var item in p)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

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
}

