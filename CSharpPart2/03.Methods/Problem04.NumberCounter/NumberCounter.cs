/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 3: Methods
 * Problem 4: Write a method that counts how many times
 *              given number appears in given array. 
 *              Write a test program to check if the 
 *              method is working correctly.
 */
using System;

namespace Problem04.NumberCounter
{
    class NumberCounter
    {
        static void Main()
        {
            int numberToCount = 2;
            Console.WriteLine("Generating a random array...");
            // generating a random test array of size 30 with the digits from 0 to 10 in it
            int[] randArr = BuildRandomIntArray(30, 0, 10);
            PrintArray(randArr);
            int repetitions = CountFrequency(randArr, numberToCount);
            Console.WriteLine("The number {0} repeats {1} times in the array.",numberToCount,repetitions);
              
            
        }
        static int  CountFrequency( int[] array, int number)
        {
            int counter = 0;
            foreach (var element in array)
            {
                if (element == number)
                {
                    counter++;
                }
            }
            return counter;
        }
        static int[] BuildRandomIntArray( int size, int low, int high)
        {
            int[] intArray = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                intArray[i] = rnd.Next(low, high+1);
            }
            return intArray;
        }
        static void PrintArray<T>(T[] collection)
        {
            Console.WriteLine();
            Console.WriteLine("Printing the collection ... ");
            foreach (var element in collection)
            {
                Console.Write("[{0}] ",element);
            }
            Console.WriteLine();
        }
    }
}
