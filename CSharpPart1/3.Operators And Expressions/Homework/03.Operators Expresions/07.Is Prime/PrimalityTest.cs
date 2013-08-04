/*
 * Lecture 3 : Operators And Expressions
 * Problem 7 : Write an expression that checks if given 
 *             positive integer number n (n ≤ 100) is prime. 
 *             E.g. 37 is prime.
 */             

using System;

class IsPrime
{
    static void Main()
    {
        Console.Write("Enter a positive integer in the range between 1 and 100 : ");
        int input = int.Parse(Console.ReadLine());
        int upMargin = (int)Math.Sqrt(input);                 //setting the upper margin of the range of numbers to be tested.There is no need to test beyond the square root of the input number
        bool isPrime = true;

        if (input == 2)                                     //if the input  number is 2 -then its prime
            {
                isPrime = true;
            }
        else if (input % 2 == 0 || input ==1)               //if the input number is even or 1(since 1 is considered not prime) ,then the number is not prime
        {
            isPrime = false;
        }
        else
        {
            for (int i = 3; i <= upMargin; i++)             //testing if the input number can be divided by the  numbers in the range from 3  to the square root of the input
            {
                if (input % i == 0)                         //if a tested number returns a reminder of 0 then the input is not prime and the loop breaks
                {
                    isPrime = false;
                    break;
                }
            }
        }
        Console.WriteLine("The number {0} is "+ (isPrime ? "prime.":"not prime."), input);

    }
}

