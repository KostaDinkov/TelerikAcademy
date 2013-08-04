/*
 * Lecture 5 : Conditional Statements
 * Problem 4 : Write a program that finds the 
 *              biggest of three integers using 
 *              nested if statements.
 */

//NOTE: instead of nested "IF"s i did kind of a Buble sort on three inputs
using System;

class SortThreeVals
{
    static void Main()
    {
        Console.Write("Enter first integer : ");
        int firstInt = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer : ");
        int secondInt = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer : ");
        int thirdInt = int.Parse(Console.ReadLine());

        int temp;
        while(!(firstInt > secondInt && secondInt > thirdInt)) //loop until the numbers are in the right position
        {
            if (firstInt < secondInt)                          //if first < second, swap positions, otherwise do nothing
            {
                temp = firstInt;
                firstInt = secondInt;
                secondInt = temp;

            }
            if (secondInt < thirdInt)                          //if second < third, swap positions, otherwise do nothing
            {
                temp = secondInt;
                secondInt = thirdInt;
                thirdInt = temp;
            }
        }
        Console.WriteLine("The result is (from greater to smaller) : {0},{1},{2}", firstInt, secondInt, thirdInt);
        

    }
}

