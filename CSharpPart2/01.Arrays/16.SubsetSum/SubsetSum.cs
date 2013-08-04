/*
* Telerik Academy  - Homework Solutions
* Course    : C# Part II
* Lecture  1: Arrays
* Problem 16: * We are given an array of integers and a
*              number S. Write a program to find if there 
*              exists a subset of the elements of the array 
*              that has a sum S. Example:
*              arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)
*/              


using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSum
{
    static void Main()
    {
        int sum = GetValidInput("Enter the sum to be tested: ");
        //array constructor
        int arrCapacity = GetValidInput("Enter Array Capacity: ",1,int.MaxValue);
        int[] array = new int[arrCapacity];
        Console.WriteLine("Enter the elements of the array, each on a new line :");
        for (int i = 0; i < arrCapacity; i++)
        {
            Console.Write("Element {0} :", i);
            array[i] = GetValidInput();
        }
        CheckForSum(array,sum);

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
    static void CheckForSum(int[] arr,int sum)
    {
        int counter = 0; 
        for (int i = 1; i < Math.Pow(2,arr.Length); i++)       
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
            if (subSet.Sum() == sum)
            {
                //increase counter by 1
                counter++;
                // print the elements of the subSet list in a formula like "(a)+(b)+(-c)=sum"
                Console.Write("(" + string.Join(")+(", subSet) + ") = {0}\n",sum);
                //clear the list to start another subset
                subSet.Clear();
            }
        }
        Console.WriteLine("The number of subsets with SUM that is equal to {0} is: {1}",sum, counter);
    }
}

