/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Text Files
 * Problem 5: Write a program that reads a text file containing a 
 *              square matrix of numbers and finds in the matrix an 
 *              area of size 2 x 2 with a maximal sum of its elements. 
 *              The first line in the input file contains the size of matrix N. 
 *              Each of the next N lines contain N numbers separated by space. 
 *              The output should be a single number in a separate text file. 
 *              Example:
 *                       4
 *                       2 3 3 4
 *                       0 2 3 4		--->	17
 *                       3 7 1 2
 *                       4 3 3 2
 */
 
using System;

using System.IO;

namespace Problem05Matrix
{
    class mainClass
    {
        static void Main()
        {
            string filePath = @"..\..\matrix.txt"; // change this to test with different matrix file

            int[,] matrix = MatrixBuilder(filePath);
            
            using (StreamWriter writer = new StreamWriter(@"..\..\result.txt")) //writing to a file named result.txt in the project dir
            {
                writer.WriteLine(FindMaxSumInArea(matrix, 2));

            }
        }

        private static int[,] MatrixBuilder(string filePath)
        {
            string line;
            int row = 0;
            int col = 0;
            int[,] matrix;

            using (StreamReader reader = new StreamReader(filePath))
            {
                int matrixSize = int.Parse(reader.ReadLine());
                matrix = new int[matrixSize, matrixSize];
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (var element in line)
                    {
                        if (element != ' ')
                        {
                            matrix[row, col] = int.Parse(element.ToString());
                            col++;
                        }
                    }
                    row++;
                    col = 0;
                }
            }
            return matrix;
        }
        
        private static int FindMaxSumInArea(int[,] array, int areaSize)
        {
            int maxSum = int.MinValue;
            int currentSum = 0;
            for (int row = 0; row < array.GetLength(0)-areaSize+1; row++)
            {
                for (int col = 0; col < array.GetLength(1)-areaSize+1; col++)
                {
                    for (int xOffset = 0; xOffset < areaSize; xOffset++)
                    {
                        for (int yOffset = 0; yOffset < areaSize; yOffset++)
                        {
                            currentSum += array[row + xOffset,col+yOffset];
                        }
                    }
                    if (currentSum>maxSum)
                    {
                        maxSum = currentSum;
                    }
                    currentSum = 0;
                    
                }
            }
            
            return maxSum;
        }
    }
}
