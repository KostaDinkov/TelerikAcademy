/*
 * Lecture 5 : Conditional Statements
 * Problem 9 : We are given 5 integer numbers. 
 *              Write a program that checks if 
 *              the sum of some subset of them is 0. 
 *              Example: 3, -2, 1, 1, 8  1+1-2=0.
 */              


//NOTE: Using the binary representation of the posible subset combinations method as 
//presened by Николай Костов at 
//http://www.youtube.com/watch?v=Sk0PX0YSHtk
//at 1:06:30 
//NOTE:Overcomenting for educational purposes

using System;
using System.Collections.Generic;
using System.Linq;

class SubSetSum
{
    static void Main()
    {
        int[] numbers = new int[5];         //creating an array to hold the 5 input numbers
        int counter = 0;                    //a variable to hold the current count of valid results
        Console.WriteLine("Enter five integers, each on a new row :");
        
        for (int i = 0; i < 5; i++)         //read the input and add the numbers to the array
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < 32; i++)       //*Read the explanation of the technique belo
        {
            List<int> subSet = new List<int>();

            for (int j = 0; j < 5; j++)                    
            {
                if (((i >> j) & 1) * numbers[j]!=0)
	            {
                    subSet.Add(numbers[j]);
	            }
            }
            //if the sum of the elements in the subSet array is 0 then... 
            if (subSet.Sum() == 0)                                        
            {
                //increase counter by 1
                counter++;                  
                // print the elements of the subSet list in a formula like "(a)+(b)+(-c)=0"
                Console.Write("(" + string.Join(")+(", subSet) + ") = 0\n");
                //clear the list to start another subset
                subSet.Clear();             
            }
        }
        Console.WriteLine("The number of subsets which SUM equals 0 is: " + counter);
    }
}
//the loops repeats 31(wich is (2 to the 5th power) -1) number of times, wich is the number of the posiible subsets
//for every number in the numbers array do the following...
//check if (i >> j) & 1) * numbers[j]!=0 and if so , add the numbers[j] to the subSet list
//the first part (i >> j) & 1) is the formula used to construct the possible subsets
//if (i >> j) & 1) returns zero, then 0*numbers[j] will also be zaro and the numbers[j]
//will not be a part of the current subset being constructed. "i" can be from 1 to 31, and "j" from 0-4
//After we construct the first subset (subSet list), we use the .Sum()method to add
//all of the elements of the list together and check if the sum is qeual to 0.

