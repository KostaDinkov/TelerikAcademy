/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 1: Multidimensional Arrays
 * Problem 1: Write a program that fills and prints a matrix of 
 *              size (n, n) as shown below: (examples for n = 4)
 */

using System;
using System.Linq;

namespace _01.MatrixVariations
{
    class MatrixVariations
    {
        static void Main()
        {
            // Get array size
            int arrSize = GetValidInput("Enter a size for the array: ", 1);
            // Normal array - case a)
            int[,] normalArray = BuildNormalArray(arrSize);
            PrintArray(normalArray);

            // ZigZag array - case b)
            int[,] zigzagArray = BuildZigZagArray(arrSize);
            PrintArray(zigzagArray);

            // Diagonal array - case c)
            int[,] diagonalArray = BuildDiagonalArray(arrSize);
            PrintArray(diagonalArray);

            // Spiral array - case d)*
            int[,] spiralArray = BuildSpiralAray(arrSize);
            PrintArray(spiralArray);
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
        static int[,] BuildNormalArray(int n)
        {
            int[,] array = new int[n, n];
            int startNumber = 1;
            for (int col = 0; col < array.GetLength(0); col++)
            {
                for (int row = 0; row < array.GetLength(1); row++)
                {
                    array[row, col] = startNumber;
                    startNumber++;
                }
            }
            return array;
        }
        static int[,] BuildZigZagArray(int n)
        {
            int[,] array = new int[n, n];
            int startNumber = 1;
            int row = 0;

            for (int col = 0; col < array.GetLength(0); col++)
            {
                if (row < array.GetLength(1))
                {
                    for (int i = 0; i < array.GetLength(1); i++)
                    {
                        array[i, col] = startNumber;
                        startNumber++;
                        row++;
                    }
                }
                else
                {
                    for (int i = array.GetLength(1) - 1; i >= 0; i--)
                    {
                        array[i, col] = startNumber;
                        startNumber++;
                        row--;
                    }
                }
            }
            return array;
        }
        static int[,] BuildDiagonalArray(int n)
        {
            // part 1
            int row = n - 1;
            int number = 1;
            int[,] array = new int[n, n];
            for (int currentWidth = 1; currentWidth <= n; currentWidth++)
            {
                for (int col = 0; col < currentWidth; col++)
                {
                    array[row, col] = number;
                    if (row < 0)
                    {
                        row = n - 1;
                    }
                    if (row < n - 1)
                    {
                        row++;
                    }
                    number++;
                }
                row = row - currentWidth;
            }
            // part 2
            row = 0;
            int column = 1;
            int startCol = 1;
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    array[row, column] = number;
                    number++;
                    row++;
                    column++;
                }
                row = 0;
                startCol += 1;
                column = startCol;
            }

            return array;
        }
        static int[,] BuildSpiralAray(int n)
        {
            int[,] array = new int[n, n];
            int direction = 1;
            int row = 0;
            int col = 0;
            int number = 2;
            bool drawRow = true;
            array[row, col] = 1;

            while (number <= (n * n))
            {
                if (drawRow) // draw down the rows
                {
                    // if the next array element is in the array and if it is empty, go there and write the number
                    if (row + direction < n && row + direction >= 0 && array[row + direction, col] == 0)
                    {
                        row += direction;
                        array[row, col] = number;
                        number++;
                    }
                    // else stop drawing on the row
                    else drawRow = !drawRow;
                }
                if (!drawRow) // draw on the columns
                {
                    // if the next array element is in the array and if it is empty, go there and write the number
                    if (col + direction < n && array[row, col + direction] == 0)
                    {
                        col += direction;
                        array[row, col] = number;
                        number++;
                    }
                    else
                    {
                        // else stop drawing on the column and change the direction ( left, right, up, down)
                        drawRow = !drawRow;
                        direction *= -1; // change the direction
                    }
                }

            }
            return array;
        }
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
}
