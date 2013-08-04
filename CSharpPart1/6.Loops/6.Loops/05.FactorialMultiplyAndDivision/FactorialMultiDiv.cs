/*
 * Lecture 6 : Loops
 * Problem 5 : Write a program that calculates N!*K! / (K-N)! 
 *              for given N and K (1<N<K). 
 */              

using System;
using System.Numerics;

class FactorialMultiDiv
{
    static void Main()
    {
        Console.WriteLine("Enter two integers N and K, such as (1 < K < N).");
        int numberK;
        int numberN;
        
        BigInteger factN = 1;
        BigInteger factK = 1;
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
        while (!(isValidInput) || (numberK >= numberN) || (numberK <= 1));
        int nMinusK = numberN - numberK;
        while (numberN > 0) //find the factorial of N
        {
            factN = factN * numberN;
            numberN--;
        }
        Console.WriteLine("Factorial of N is : " +factN);
        while (numberK > 0)//find the factorial of K
        {
            factK = factK * numberK;
            numberK--;
        }
        Console.WriteLine("Factorial of K is : " + factK);
        
        BigInteger factNK = 1; ;
        
        while (nMinusK > 0)//find the factorial of (N-K)
        {
            factNK = factNK * nMinusK;
            nMinusK--;
        }
        Console.WriteLine("Factorial of (N-K) is : " + factNK);
        Console.WriteLine("(!N/!K)/(N-K)! = " + (factN / factK)/factNK);

    }
}

