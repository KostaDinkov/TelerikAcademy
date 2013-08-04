/*
 * Lecture 4 : Console Input Output
 * Problem 10: Write a program to calculate the sum 
 *              (with accuracy of 0.001): 
 *              1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
 */              


using System;

    class AltHarmonics
    {
        static void Main()
        {
            double sum=1.0;             //a var to store the sum, starting from 1; 
            int divisor = 2;            //the devisor starting from 2
            double previousSum=0.0;     //a var to store the sum of a previous addition

            while (Math.Round(sum, 3) - Math.Round(previousSum, 3) != 0) //repeat until the current sum and the 
                                                                         //sum of a previous addition (both rouned to the third 
                                                                         //sign after the decimal point) are equal.   
            {
                previousSum = sum;
                if (divisor % 2 == 0)                                   //if the divisor is even, perform addition
                {
                    sum = sum + 1.0 / divisor;
                }
                else
                    sum = sum - 1.0 / divisor;                          //if the divisor is odd, perform sustraction
                divisor++;                                              //increase the divisor by 1

            }
            
            Console.WriteLine("{0:f3}",previousSum);    //print both the previous sum and the current sum to check if when rounded to the third ...
            Console.WriteLine("{0:f3}",sum);            //...symbol after the decimal point, they are equal
        }
    }

