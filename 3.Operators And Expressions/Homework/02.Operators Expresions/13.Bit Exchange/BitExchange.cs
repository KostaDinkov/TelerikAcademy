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
        
        uint inputInt = uint.Parse(Console.ReadLine());                               //Read the input number
        string inputStr = Convert.ToString(inputInt,2).PadLeft(32,'0');             //Convert Input to binary string representation with leading zeros 
        int[] inputArray = inputStr.Select(c => int.Parse(c.ToString())).ToArray(); //Create an array of ints from the string; example: {0,0,0,1,0,...,1,0}
        
        PrintValues(inputArray);                                                    //Display the values of the array                                                  

        int[] positionsA = { 3, 4, 5 };                                             //Array for storing the first sequence of bit positions to be swaped.
        int[] positionsB = { 24, 25, 26 };                                          //Array for storing the second sequence of bit positions to be swaped.
        
        int[] resultArray = (int[])inputArray.Clone();                              //Creating a copy of the input number array

        
        int arrayPosA = Math.Abs(positionsA[2] - 31);                    //Since the indexing of an Array starts from left to right and we count bits in numbers
        int arrayPosB = Math.Abs(positionsB[2] - 31);                    //from right to left a simple adjusting is needed.Note also that we use only the last index in
                                                                         //the positions arrays - 5 and 26.That is because the position sequences are successive.

        //Using the Array.Copy method .It works like that : Copies a sequence of successive indexes from the source array and places them at a given position(index) in the target array.
        //Format: Array.Copy(sourceArray,sourceIdex,targetArray,targetIndex,int) where int is the lenght of the sequence of indexes to be copied.
        
        Array.Copy(inputArray, arrayPosA, resultArray, arrayPosB, 3);  
        Array.Copy(inputArray, arrayPosB, resultArray, arrayPosA, 3);     
                                                                                                                
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

