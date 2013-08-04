/*
* Telerik Academy  - Homework Solutions
* Course    : C# Part II
* Lecture  1: Arrays
* Problem 19: * Write a program that reads a number 
*               N and generates and prints all the 
*               permutations of the numbers [1 … N]. 
*               Example:n = 3  {1, 2, 3}, {1, 3, 2}, 
*               {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
*/

//NOTE: Using a Combinatorics library for problems 19,20,21 (  gets the job done pretty well )
//http://www.codeproject.com/Articles/26050/Permutations-Combinations-and-Variations-using-C-G

using System;
using System.Collections.Generic;
using System.Linq;
using Combinatorics.Collections;


class Permute

{
    static void Main()
    {
        int N = GetValidInput("Enter the upper margin for the permutations range( 1 to N ): ", 2);
        //build the array
        List<int> numbers = new List<int>();
        for (int i = 1; i <= N; i++)
        {
            numbers.Add(i);
        }
        //generate a permutations collection
        Permutations<int> permutations = new Permutations<int>(numbers);
        //print the elements in the collection
        foreach (IList<int> p in permutations)
        {
            foreach (var item in p)
            {
                Console.Write(item);
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

