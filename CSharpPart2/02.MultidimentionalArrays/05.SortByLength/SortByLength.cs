/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 1: Multidimensional Arrays
 * Problem 5: You are given an array of strings. 
 *              Write a method that sorts the array 
 *              by the length of its elements 
 *              (the number of characters composing them).
 */

using System;
using System.Linq;

class SortByLength
{
    static void Main()
    {
        string[] stringList = 
	    {
	        "stegosaurus",
	        "piranha",
	        "leopard",
	        "cat",
	        "bear",
	        "hyena"
	    };
        PrintArray(stringList);
        Console.WriteLine("Unsorted Array: ");
        Console.WriteLine();
        Console.WriteLine("Sorting the array ...");
        Console.WriteLine();
        PrintArray(SortStringByLength(stringList));

    }
    static void PrintArray<T>(T[] array)
    {
        Console.WriteLine();
        foreach (var item in array)
        {
            Console.Write("[{0}] ", item);
        }
        Console.WriteLine();
    }
    static string[] SortStringByLength(string[] e)
    {
        // Use LINQ to sort the array received and return a copy.
        var sorted = from s in e
                     orderby s.Length ascending
                     select s;
        return sorted.ToArray();
    }
}


