/*
 * Lecture 3 : Operators and Expressions
 * Problem 23: Write a program that exchanges bits 3, 4 
 *             and 5 with bits 24, 25 and 26 of given 
 *             32-bit unsigned integer.
 */


using System;
using System.Linq;

class BitExchange
{
    static void Main()
    {
        
        int inputInt = int.Parse(Console.ReadLine());
        string inputStr = Convert.ToString(inputInt,2).PadLeft(32,'0');
        int[] inputArray = inputStr.Select(c => int.Parse(c.ToString())).ToArray();
        
        PrintValues(inputArray);

        int[] positionsA = { 3, 4, 5 };
        int[] positionsB = { 24, 25, 26 };
        
        int[] resultArray = (int[])inputArray.Clone();
        Array.Copy(inputArray, Math.Abs( positionsA[2]-31), resultArray, Math.Abs(positionsB[2]-31), 3);
        Array.Copy(inputArray, Math.Abs(positionsB[2]-31), resultArray, Math.Abs(positionsA[2]-31), 3);
        
        PrintValues(resultArray);
        
       
    }
    //a helper function for displaying the values of an Array
    public static void PrintValues(Array myArr)
    {
        foreach (int i in myArr)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
}

