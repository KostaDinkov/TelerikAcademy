/*
 * Telerik Academy  - Homework Solutions
 * Course    : C# Part II
 * Lecture  1: Arrays
 * Problem 15: Write a program that finds all prime numbers in the range 
 *              [1...10 000 000]. Use the sieve of Eratosthenes algorithm 
 *              (find it in Wikipedia).
 */

using System;
using System.Linq;

class SieveOfEratosthenes
{
    static void Main()
    {
        long sum = 0;
        long range= 10000000;
        bool[] boolArr = new bool[range];//by default they're all false so...
        for (int i = 2; i < range; i++)
        {
            boolArr[i] = true;//set all numbers to true
        }

        //set all non primes to false by finding mutiples 
        for (int j = 2; j < range; j++)
        {
            if (boolArr[j])//is true
            {
                for (long p = 2; (p * j) < range; p++)
                {
                    boolArr[p * j] = false;
                }
            }
        }
        //print the indexes of the true values in the array
        for(int i = 0; i<boolArr.Length;i++)
        {
            if (boolArr[i])
            {
                Console.Write(i+"  ");
            }
        }
    }
    
    
}

