/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 1: Multidimensional Arrays
 * Problem 2: Write a program that reads a rectangular matrix 
 *              of size N x M and finds in it the square 3 x 3 
 *              that has maximal sum of its elements.
 */

using System;
using System.Linq;

class MaxFieldSum
{
    static void Main()
    {
        int arrayHight = GetValidInput("Enter the height of the matrix (min 3) : ", 3);
        int arrayWidth = GetValidInput("Enter the width of the matrix (min 3) : ", 3);
        //generate random matrix with the given dimensions, rather than inputing all the numbers from the console.
        int[,] array = BuildRandomMatrix(arrayHight, arrayWidth); 
        PrintArray(array);
        int[,] result = GetMaxSumField(array, 3);
        PrintArray(result);
    }
    /// <summary>
    /// Prompts for entering an integer of type int, in a specified range. Performs a check for validating the input.
    /// </summary>
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
    /// <summary>
    /// Builds a matrix with given dimentions and populates it with random numbers from a given range
    /// </summary>
    /// <param name="hight">Matrix height</param>
    /// <param name="width">Matrix width</param>
    /// <param name="minNumber">Low margin for the random numbers range</param>
    /// <param name="maxNumber">Top margin for the random numbers range</param>
    static int[,] BuildRandomMatrix(int hight, int width, int minNumber=1, int maxNumber=100)
    {
        int[,] result = new int[hight, width];
        Random rnd = new Random();
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < hight; j++)
            {
                result[j, i] = rnd.Next(minNumber, maxNumber);
            }
        }
        return result;
    }
    /// <summary>
    /// Returns a sub matrix of size fieldSize*fieldSize from the input matrix, with the highest sum of its elements
    /// </summary>
    /// <param name="array">The input matrix</param>
    /// <param name="fieldSize">The size of the sub matrix</param>
    /// <returns></returns>
    static int[,] GetMaxSumField( int[,] array, int fieldSize)
    {
        int arrayHight = array.GetLength(0);
        int arrayWidth = array.GetLength(1);
        int maxSum = int.MinValue;
        int currentSum = 0;
        int[,] currentField = new int[fieldSize, fieldSize];
        int[,] bestField = new int[fieldSize, fieldSize];

        for (int i = 0; i < arrayWidth - fieldSize+1; i++)
        {
            for (int j = 0; j < arrayHight - fieldSize+1; j++)
            {
                for (int colOffset = 0; colOffset < fieldSize; colOffset++)
                {
                    for (int rowOffset = 0; rowOffset < fieldSize; rowOffset++)
                    {
                        currentSum = currentSum + array[j + rowOffset, i + colOffset];
                        currentField[rowOffset, colOffset] = array[j + rowOffset, i + colOffset];
                    }
                }
                if (currentSum>maxSum)
                {
                    maxSum = currentSum;
                    bestField = (int[,])currentField.Clone();
                    
                }
                currentSum = 0;
            }
        }
        return bestField;
    }
    /// <summary>
    /// Prints the elements of a  2d matrix on the console
    /// </summary>
    /// <param name="array"></param>
    static void PrintArray(int[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write("{0,5}", array[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

