/*
 * Lecture 6 : Loops
 * Problem 4 : Write a program that calculates 
 *              N!/K! for given N and K (1<K<N).
 */              

//NOTE: Using the BigIneger data type to handle bigger numbers

using System;
using System.Numerics;

class FactorialDivision
{
    static void Main()
    {
        Console.WriteLine("Enter two integers N and K, such as (1 < K < N).");
        int numberK;
        int numberN;
        BigInteger factN=1;
        BigInteger factK=1;
        bool isValidInput;
        do
        {
            Console.Write("Enter number N : ");
            isValidInput = int.TryParse(Console.ReadLine(), out numberN);

        }
        while (!(isValidInput) || (numberN <= 1));
        do
        {
            Console.Write("Enter number K : ");
            isValidInput = int.TryParse(Console.ReadLine(), out numberK);

        }
        while (!(isValidInput) || (numberK >= numberN) || (numberK <=1));

        while (numberN >0) //find the factorial of N
        {
            factN = factN * numberN;
            numberN--;
        }
        while (numberK > 0)//find the factorial of K
        {
            factK = factK * numberK;
            numberK--;
        }
        Console.WriteLine("!N/!K = " + (factN/factK));

    }
}

