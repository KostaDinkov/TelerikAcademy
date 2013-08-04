/*
 * Lecture 6 : Loops
 * Problem 14: * Write a program that reads a positive 
 *              integer number N (N < 20) from console and 
 *              outputs in the console the numbers 1 ... N 
 *              numbers arranged as a spiral.
 */

//Working in a big range of numbers not only 20
//It turned out a little sloppy as a style, but it works

using System;

class SpiralMatrix
{
    static void Main()
    {
        // Constructing the matrix
        Console.Write("Enter an integer (max 20) : ");
        int matrixSize = int.Parse(Console.ReadLine());
        int x = matrixSize;
        int y = matrixSize;
        
        
        Console.WriteLine();
        int[,] matrix = new int[x, y]; // build the matrix


        int xUpper = x - 1;  //right margin (index)
        int yUpper = y - 1;  //bottom margin (index)
        int xLower = 0;      //left margin
        int yLower = 0;      //top margin
        int xPosition = 0;   // x of the current position to be filled
        int yPosition = 0;   // y of the current position to be filled
        int step = 0;        // a step is the filling of an entire row or column
        int sign = 1;        // a variable used to change the direction of filling ( left or right, up or down ) 
        int number = 1;      // a variable to hold the current number to be added to the matrix 

        // main loop repeats until all numbers in the range from 1 to the input number are added 
        while (number <= (matrixSize*matrixSize))
        {
            step++;
            //on each odd step exept step 1 , change the direction of the itteration
            if (step > 1 && step % 2 != 0)
            {
                sign = sign * (-1);
            }
            if (step != 1)
            {
                xPosition = xPosition + sign;
            }
            // fill a row in the margin range
            while (xPosition >= xLower && xPosition <= xUpper)
            {
                if (number > matrixSize*matrixSize)
                {
                    break;
                }
                matrix[xPosition, yPosition] = number;
                if (xPosition < xUpper && xPosition >= xLower)
                {
                    xPosition = xPosition + sign;
                }
                else
                {
                    number++;
                    break;
                }
                number++;
            }
            if (xPosition < xLower)
            {
                xPosition = xLower;
            }

            //Adjust Margins after each step
            if (step % 4 == 1 && step > 1)
            {
                xLower++;
            }
            else if (step % 4 == 2)
            {
                yLower++;
            }
            else if (step % 4 == 3)
            {
                xUpper--;
            }
            else if (step % 4 == 0)
            {
                yUpper--;
            }
            //NEWSTEP
            step++;
            yPosition = yPosition + sign;
            // fill a column in the margin range
            while (yPosition <= yUpper && yPosition >= yLower)
            {
                if (number > matrixSize*matrixSize)
                {
                    break;
                }
                matrix[xPosition, yPosition] = number;

                if (yPosition < yUpper && yPosition >= yLower)
                {
                    yPosition = yPosition + sign;
                    if (yPosition > yUpper)
                    {
                        yPosition = yUpper - 1;
                    }
                }
                else
                {
                    number++;
                    break;
                }
                number++;
            }
            if (yPosition < yLower)
            {
                yPosition = yLower;
            }
            //Adjust Margins after each step
            if (step % 4 == 1 && step > 1)
            {
                xLower++;
            }
            else if (step % 4 == 2)
            {
                yLower++;
            }
            else if (step % 4 == 3)
            {
                xUpper--;
            }
            else if (step % 4 == 0)
            {
                yUpper--;
            }
        }
        //Print the Matrix to the console
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("[" + Convert.ToString(matrix[j, i]).PadLeft(3, ' ') + "]");
            }
            Console.WriteLine();
        }
    }

}

