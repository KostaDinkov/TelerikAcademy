// Lecture 1: Intro to programming
// Problem 8: Create a console application that calculates and prints the square of the number 12345.

using System;

class Square
{
    static void Main()
    {
        Console.WriteLine("The number 12345 to the second power is: "+ Math.Pow(12345,2.0)+"\n");
        // or
        //Console.WriteLine(12345*12345);
        //note: No Power operator in C# !?
    }
}

