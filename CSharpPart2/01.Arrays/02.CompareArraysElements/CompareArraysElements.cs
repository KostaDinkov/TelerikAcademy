/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 1: Arrays
 * Problem 2: Write a program that reads two arrays 
 *              from the console and compares them element 
 *              by element.
 */
using System;

class CompareArraysElements
{
    static void Main()
    {
        Console.WriteLine("Enter the capacity for the arrays\n(a positive integer in the range from 1 to {0}: ", int.MaxValue);
        int arrayCapacity;
        bool valid = int.TryParse(Console.ReadLine(), out arrayCapacity);
        if (valid == false)
        {
            Console.WriteLine("Invalid input!");
        }

        int[] firstArray = new int[arrayCapacity];
        int[] secondArray = new int[arrayCapacity];

        Console.WriteLine("Enter the ellements of the first array\n(each on a new line)...");

        for (int i = 0; i < arrayCapacity; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter the ellements of the second array\n(each on a new line)...");

        for (int i = 0; i < arrayCapacity; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        for (int index = 0; index < arrayCapacity; index++)
        {
            int element1 = firstArray[index];   //the element at position "index" in the first array
            int element2 = secondArray[index];  //the element at position "index" in the second array
            string comparrison = Compare(firstArray[index], secondArray[index]);
            Console.WriteLine("Element {0}[{1}] from the first array\n{2} element {0}[{3}] from the second array.",
                index,
                element1,
                comparrison,
                element2);
            Console.WriteLine();
        }


    }
    /// <summary>
    /// Compares two integers and returns a string representation of the result
    /// </summary>
    static string Compare(int a, int b)
    {
        string result;
        if (a == b)
        {
            result = "equals";
        }
        else if (a < b)
        {
            result = "is lesser than";
        }
        else
        {
            result = "is greater than";
        }
        return result;
    }
}

