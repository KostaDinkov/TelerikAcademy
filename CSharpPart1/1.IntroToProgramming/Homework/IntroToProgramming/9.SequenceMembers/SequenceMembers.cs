// Lecture 1: Intro to programming
// Problem 9: Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class SequenceMembers
{
    static void Main()
    {
        //a loop for repeating the procedure 10 times starting from '2'
        for (int i = 2; i < 12; i++)
        {
            //if the number is even, print the number
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            //if the number is odd, multiply by -1 and print
            else
            {
                Console.WriteLine(i*(-1));
            }
        }
    }
}

