/*
 * Lecture 4 : Console Input Output
 * Problem 1 : Write a program that reads 3 
 *             integer numbers from the console 
 *             and prints their sum.
 */

using System;

class ThreeInts
{
    static void Main()
    {
        Console.Write("Insert the first integer: ");
        int firstInt = int.Parse(Console.ReadLine());
        Console.Write("Insert the second integer: ");
        int secondInt = int.Parse(Console.ReadLine());
        Console.Write("Insert the third integer: ");
        int thirdInt = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("The first integer is : "+ firstInt);
        Console.WriteLine("The second integer is : "+ secondInt);
        Console.WriteLine("The third integer is : "+ thirdInt);
        Console.WriteLine();
    }
}

