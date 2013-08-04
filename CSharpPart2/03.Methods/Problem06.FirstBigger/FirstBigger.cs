/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 3: Methods
 * Problem 6: Write a method that returns the index of 
 *              the first element in array that is bigger 
 *              than its neighbors, or -1, if there’s no 
 *              such element. Use the method from the previous 
 *              exercise.
 */


//Note This time the method will return true only if both neighbors exist 
using System;

namespace Problem06.FirstBigger
{
    class FirstBigger
    {
        static void Main()
        {
            const int arraySize = 20; // the size of the random array to be generated
            const int lowMarg = 0;    // the low number of the range to choose random numbers from  
            const int highMarg = 100; // the high number of the range to choose random numbers from  
            int[] randomArray = BuildRandomIntArray(arraySize, lowMarg, highMarg);
            PrintArray(randomArray);
            Console.WriteLine("The index of the first number that is bigger than its neighbors is {0}", GetFirstBiggerIndex(randomArray));
        }
        static int GetFirstBiggerIndex(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (CheckIfBiggerThanNeighbours(array, i))
                {
                    return i;
                }
                
            }
            return -1;
        }
        static bool CheckIfBiggerThanNeighbours(int[] array, int index)
        {
            bool isBigger = false;
            int number = array[index];
            int leftNeighbor = index - 1;
            int rightNeighbor = index + 1;
            //check if neighbor exists
            if (leftNeighbor < 0)
            {
                //Console.WriteLine("Neighbor to the left doesn't exist!");
                //Console.WriteLine();
                //isBigger = IsBigger(number, array[rightNeighbor]);
                return false;
            }
            else if (rightNeighbor == array.Length)
            {
                //Console.WriteLine("Neighbor to the right doesn't exist!");
                //Console.WriteLine();
                //isBigger = IsBigger(number, array[leftNeighbor]);
                return false;
            }
            // when the two neighbors exist
            else
            {
                isBigger = IsBigger(number, array[leftNeighbor]) && IsBigger(number, array[rightNeighbor]);
            }

            return isBigger;
        }
        /// <summary>
        /// Returns True if the first number is bigger than the second
        /// </summary>
        static bool IsBigger(int a, int b)
        {
            if (a > b)
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
