/*
 * Lecture 4 : Console Input Output
 * Problem 10: Write a program to print the first 100 
 *              members of the sequence of Fibonacci: 
 *              0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 */              

using System;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {   
        //using the BigInteger type because the numbers get really big
        BigInteger previousNum = 0; 
        BigInteger nextNum = 1;
        BigInteger sum = 0;
        Console.Write("{0},{1},",previousNum,nextNum);
        
        for (int i = 0; i < 98; i++)               //the loop repeats 100 times
        {                                           //on each iterration...
            sum = previousNum + nextNum;            //we add the last number of the sequence to the number before it...            
            Console.Write(sum +",");                //we print the sum then...
            previousNum = nextNum;                  //the last number becomes the number before the last and...
            nextNum = sum;                          //...the sum becomes the last number.
            
        }
        Console.WriteLine();
    }
}

