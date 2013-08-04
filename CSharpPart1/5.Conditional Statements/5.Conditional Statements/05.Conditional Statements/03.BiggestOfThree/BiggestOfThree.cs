/*
 * Lecture 5 : Conditional Statements
 * Problem 3 : Write a program that finds the 
 *              biggest of three integers using 
 *              nested if statements.
 */              

using System;

class BiggestOfThree
{
    static void Main()
    {
        Console.Write("Enter first integer : ");
        int firstInt = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer : ");
        int secondInt = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer : ");
        int thirdInt = int.Parse(Console.ReadLine());

        if (firstInt > secondInt)
        {
            if (firstInt > thirdInt)
            {
                Console.WriteLine(firstInt);
            }
            else
            {
                Console.WriteLine(thirdInt);
            }
        }
        else
        {
            if (secondInt >thirdInt)
            {
                Console.WriteLine(secondInt);
            }
            else
            {
                Console.WriteLine(thirdInt);
            }
        }
    }
}

