using System;
using System.Collections.Generic;
class BinarySearch
{
    static void Main()
    {
        
        //array constructor
        int arrCapacity = GetValidInput("Enter array capacity: ");
        List<int> list = new List<int>();
        Console.WriteLine("Enter the elements of the array, each on a new line :");
        for (int i = 0; i < arrCapacity; i++)
        {
            Console.Write("Element {0}", i);
            int newEllement = GetValidInput(" ->", int.MinValue, int.MaxValue);
            list.Add(newEllement);
        }
        list.Sort();// sorting the input list
        Console.WriteLine("The array sorted: ");
        foreach (var item in list)
        {
            Console.Write(item+"; ");
        }
        Console.WriteLine();
        
        int ellement = GetValidInput("Enter the ellement you wish to find the index of: ",int.MinValue, int.MaxValue);
        int indexOfEllement = GetIndexOf(ellement, list);
        Console.WriteLine("Inex of {0} is {1}",ellement, indexOfEllement);

        

    }
    /// <summary>
    /// Returns the index of an element in a sorted list using binary search
    /// </summary>
    static int GetIndexOf(int element, List<int> list)
    {
        int lo = 0;
        int hi = list.Count;
        int mid = (lo + hi) / 2;
        while (element != list[mid])
        {
            mid = (lo + hi) / 2;
            if (element < list[mid])
            {
                hi = mid-1;
            }
            else
            {
                lo = mid+1;
            }
        }
        return mid;
        
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
                isValid= false;
            }
        }
        while (isValid == false );
        return input;
    }
}

