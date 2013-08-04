/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 3: Methods
 * Problem 5: Write a method that checks if the element
 *              at given position in given array of 
 *              integers is bigger than its two 
 *              neighbors (when such exist).
 */

using System;

namespace Problem5.CompareWithNeighbors
{
    class CompareEithNeighbours
    {
        static void Main()
        {
            const int arraySize = 20; // the size of the random array to be generated
            const int lowMarg = 0;    // the low number of the range to choose random numbers from  
            const int highMarg = 100; // the high number of the range to choose random numbers from  
            int[] randomArray = BuildRandomIntArray(arraySize, lowMarg, highMarg);
            PrintArray(randomArray);
            int index = GetValidInput("Enter the index of the element to be compared : ", 0, arraySize - 1);
            CheckIfBiggerThanNeighbours(randomArray, index);
        }
        static void CheckIfBiggerThanNeighbours( int[] array, int index)
        {
            bool isBigger = false;
            int number = array[index];
            int leftNeighbor = index - 1;
            int rightNeighbor = index + 1;
            //check if neighbor exists
            if (leftNeighbor < 0 )
            {
                Console.WriteLine("Neighbor to the left doesn't exist!");
                Console.WriteLine();
                isBigger =  IsBigger(number, array[rightNeighbor]);
            }
            else if (rightNeighbor>=array.Length)
            {
                Console.WriteLine("Neighbor to the right doesn't exist!");
                Console.WriteLine();
                isBigger= IsBigger(number, array[leftNeighbor]);
            }
            // when the two neighbors exist
            else
            {
                isBigger = IsBigger(number, array[leftNeighbor]) && IsBigger(number, array[rightNeighbor]);
            }
            
            if (isBigger)
            {
                Console.WriteLine("The number {0} is bigger than its existing neighbors!", number);
            }
            else
            {
                Console.WriteLine("The number {0} is NOT bigger than its existing neighbors!", number);
            }
        }
        /// <summary>
        /// Returns True if the first number is bigger than the second
        /// </summary>
        static bool IsBigger(int a, int b)
        {
            if (a>b)
            {
                return true;
            }
            return false;
        }
        static int[] BuildRandomIntArray(int size, int low, int high)
        {
            int[] intArray = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                intArray[i] = rnd.Next(low, high + 1);
            }
            return intArray;
        }
        static void PrintArray<T>(T[] collection)
        {
            Console.WriteLine();
            Console.WriteLine("Printing the collection ... ");
            foreach (var element in collection)
            {
                Console.Write("[{0}] ", element);
            }
            Console.WriteLine();
        }
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
}
