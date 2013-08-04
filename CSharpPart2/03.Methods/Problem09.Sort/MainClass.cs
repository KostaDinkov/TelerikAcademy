/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 3: Methods
 * Problem 9: Write a method that return the maximal element in a 
 *              portion of array of integers starting at 
 *              given index. Using it write another method 
 *              that sorts an array in ascending / descending order.
 */

using System;


namespace Problem09.Sort
{
    class MainClass
    {
        static void Main()
        {
            int[] arr = { -1, -3, 4, -5, 6, -7 };

            // Ascending
            SelectionSort(arr);
            PrintArray(arr);

            // Descending
            SelectionSort(arr, descending: true);
            PrintArray(arr);
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + (i == arr.Length - 1 ? "\n" : " "));
        }
        static void Swap(int[] arr, int i, int j)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }
        static int GetBestFromPosition(int[] arr, int i, bool descending)
        {
            int best = i;

            for (i++; i < arr.Length; i++)
                if (descending ? arr[i] < arr[best] : arr[best] < arr[i])
                    best = i;

            return best;
        }
        static void SelectionSort(int[] arr, bool descending = false)
        {
            for (int i = 0; i < arr.Length; i++)
                Swap(arr, i, GetBestFromPosition(arr, i, descending));
        }
    }
}