/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 1: Arrays
 * Problem 6: Write a program that reads two integer numbers
 *              N and K and an array of N elements from the 
 *              console. Find in the array those K elements 
 *              that have maximal sum.
 */

//Note: The K elements with greater sum will always be the biggest K elemets. So...
//I'll be sorting the array first , then take a sequence of K elements from greater to smaller, 
//wich is going to be the answer.
//For skill practice purposes I will be using the simple 'Buble Sort'
using System;

class MaxSumEllements
{
    static void Main()
    {
        int arrCapacity = GetValidInput("Enter array capacity: ");
        int K = GetValidInput("Enter the number of elements to be sumarized :");
        Console.WriteLine("Enter the elements of the array, each on a new line :");
        int[] array = new int[arrCapacity];
        for (int i = 0; i < arrCapacity; i++)
        {
            Console.Write("Element {0}", i);
            array[i] = GetValidInput(" ->",int.MinValue, int.MaxValue);
        }

        // Bubble sort
        int tmp;
        bool swaped = true;
        while (swaped)
        {
            swaped = false;
            for (int i = 0; i < arrCapacity - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    tmp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = tmp;
                    swaped = true;
                }

            }
        }
        //foreach (var item in array)
        //{
        //    Console.WriteLine(item);
        //}

        //Print the K biggest numbers
        Console.WriteLine("The {0} numbers with greatest sum are :", K);
        for (int i = 0; i < K; i++)
        {
            Console.Write("{0}; ", array[i]);
        }
        Console.WriteLine();




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
