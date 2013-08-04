/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 1: Multidimensional Arrays
 * Problem 3: We are given a matrix of strings of size N x M. 
 *              Sequences in the matrix we define as sets of 
 *              several neighbor elements located on the same line, 
 *              column or diagonal. Write a program that finds the 
 *              longest sequence of equal strings in the matrix. 
 */

using System;
using System.Linq;

class EqualStringSequence
{
    static void Main()
    {
        int arrayHight = GetValidInput("Enter the height of the matrix (min 3) : ", 3);
        int arrayWidth = GetValidInput("Enter the width of the matrix (min 3) : ", 3);
        // check the coments in the class implementation for educational purposses
        RandomStringMatrix newMatrix = new RandomStringMatrix(arrayHight, arrayWidth);
        newMatrix.PrintMatrix();
        Console.WriteLine("Longest sequence length is : {0}",newMatrix.maxSeqLen);
        Console.WriteLine("The string in the longest sequence is : {0}",newMatrix.stringSeq);
        Console.WriteLine("Sequence starts at position [row: {0}, column: {1}] .",newMatrix.seqY,newMatrix.seqX);
        Console.WriteLine("Sequence direction - {0}",newMatrix.seqDirection);
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
}
class RandomStringMatrix
{
    public int xSize; //the number of the columns of the matrix
    public int ySize; //the number of the rows of the matrix
    public string[,] matrix;
    public string[] stringList = { "aa", "bb", "cc", "##", "ee" }; // the strings to fill the matrix with
    public string stringSeq; //the string that is contained in the longest sequence
    public int maxSeqLen; // the length of the longest sequence
    public int seqX; // the row at wich the longest sequence starts
    public int seqY; // the column at wich the longest sequence starts
    public string seqDirection; // the direction at wich the sequence continues from its start position
    
    // class constructor
    public RandomStringMatrix( int rows, int columns)
    {
        this.xSize = rows;
        this.ySize = columns;
        // build a matrix with size xSize columns and ySize rows
        // and populate it with random strings from stringList
        this.matrix = BuildRandomStringMatrix(this.ySize, this.xSize, this.stringList);
        // do the actual work
        FindLongestSequence(this.matrix);
    }

    private void FindLongestSequence(string[,] matrix)
    {
        int longestSeqLen = 0;
        int currentSeqLen = 1;
        int xOffset = 0;
        int yOffset = 0;
        string[] directions = { "right", "downRight", "down", "downLeft" };
        //for every row
        for (int y = 0; y < matrix.GetLength(0); y++)
        {
            // for every column
            for (int x = 0; x < matrix.GetLength(1); x++)
            {
                //for every direction in the directions list
                foreach (var direction in directions)
                {
                    //set the position for the next element that has to be compared to the current matrix element
                    if (direction == "right")
                    {
                        xOffset = 1;
                        yOffset = 0;
                    }
                    else if (direction == "downRight")
                    {
                        xOffset = 1;
                        yOffset = 1;
                    }
                    else if (direction == "down")
                    {
                        xOffset = 0;
                        yOffset = 1;
                    }
                    else if (direction == "downLeft")
                    {
                        xOffset = -1;
                        yOffset = 1;
                    }
                    
                    //if (x + xOffset < 0 || x + xOffset == matrix.GetLength(1) || y + yOffset < 0 || y + yOffset == matrix.GetLength(0))
                    //{
                    //    continue;
                    //}
                    
                    //while the next element to be compared is  in the matrix bounries
                    while (!(x + xOffset < 0 || x + xOffset == matrix.GetLength(1) || y + yOffset < 0 || y + yOffset == matrix.GetLength(0)))
                    {   
                        //if the next element equals the first one, continue checking in the same direction
                        if (matrix[y, x] == matrix[y + yOffset, x + xOffset])
                        {
                            currentSeqLen += 1;
                            // moving to the next element in the current direction
                            if (xOffset > 0)
                            {
                                xOffset += 1;
                            }
                            else if (xOffset < 0)
                            {
                                xOffset -= 1;
                            }
                            if (yOffset > 0)
                            {
                                yOffset += 1;
                            }
                            else if (yOffset < 0)
                            {
                                yOffset -= 1;
                            }
                        }
                        else break;
                    }
                    // set the longest sequence length found so far and...
                    //...record its start position and the string of wich the sequence is built
                    if (currentSeqLen > longestSeqLen)
                    {
                        longestSeqLen = currentSeqLen;
                        this.stringSeq = matrix[y,x];
                        this.seqX = x;
                        this.seqY = y;
                        this.seqDirection = direction;
                    }
                    //reset current length
                    currentSeqLen = 1;
                }
            }
        }
        this.maxSeqLen = longestSeqLen;
    }
    private  string[,] BuildRandomStringMatrix(int hight, int width, string[] strings)
    {
        string[,] result = new string[hight, width];
        Random rnd = new Random();
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < hight; j++)
            {
                int index = rnd.Next(strings.Length);
                result[j, i] = strings[index];
            }
        }
        return result;
    }
    public void PrintMatrix()
    {
        Console.WriteLine("Generating Random Matrix...");
        Console.WriteLine();
        for (int i = 0; i < this.matrix.GetLength(1); i++)
        {
            Console.Write("{0,4}", i);
            
        }
        Console.WriteLine();
        Console.WriteLine();
        for (int row = 0; row < this.matrix.GetLongLength(0); row++)
        {
            Console.Write(row);
            for (int col = 0; col < this.matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", this.matrix[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

