/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 1: Arrays
 * Problem 4: Write a program that finds the maximal 
 *              sequence of equal elements in an array.
 *              Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
 */
using System;

class MaxSequence
{
    static void Main()
    {
        int arrCapacity = GetValidInput("Enter Array Capacity: ");
        int[] array = new int[arrCapacity];
        Console.WriteLine("Enter the elements of the array, each on a new line :");
        for (int i = 0; i < arrCapacity; i++)
        {
            Console.Write("Element {0} :",i);
            array[i] = GetValidInput();

        }
        int currentEllement;

        int? bestSequenceNumber=null;
        int BestCounter=1;
        for (int index = 0; index < arrCapacity; index++)
        {
            int currentCounter = 1;
            currentEllement = array[index];
            for (int i = index+1; i < arrCapacity; i++)
            {
                if (currentEllement == array[i])
                {
                    currentCounter++;
                    if (currentCounter > BestCounter)
                    {
                        BestCounter = currentCounter;
                        bestSequenceNumber = currentEllement;
                    }
                }
                else break;
                
            }
            
        }
        Console.WriteLine("Longest Sequence : {0}, with value {1}",BestCounter,bestSequenceNumber);
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
