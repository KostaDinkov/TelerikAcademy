/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 1: Arrays
 * Problem 1: Write a program that allocates array of 20 
 *              integers and initializes each element by 
 *              its index multiplied by 5. Print the obtained 
 *              array on the console.
 */              

using System;

class IndexByFive
{
    static void Main()
    {
        //building the array. Avoiding the use of 'magic numbers' by ...
        //...declaring the array capacity and the multiplier given by the spcification
        int arrayCapacity = 20;
        int multiplier = 5;
        int[] intArray = new int[arrayCapacity];
        for (int index = 0; index < intArray.Length; index++)
        {
            intArray[index] = index * multiplier;
        }
        
        //Printing the values of the array using simple formating
        int positionIndex = 0;
        Console.WriteLine("The elements of the array are");
        Console.Write("Index:".PadRight(10,' '));
        Console.WriteLine("Value:");
        foreach (var number in intArray)
        {
            Console.Write("{0,2}",positionIndex);
            Console.WriteLine("[{0}]".PadLeft(13), number);
            positionIndex++;
        }
            
        
    }
}

