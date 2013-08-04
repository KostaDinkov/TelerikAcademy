/*
 * Lecture 5 : Conditional Statements
 * Probelm 2 : Write a program that shows the sign 
 *              (+ or -) of the product of three real 
 *              numbers without calculating it. Use 
 *              a sequence of if statements.
 */

//NOTE: Have in mind that I have tried to use 
//only "if" statemens without "if-else", or "else"

using System;

class ProductOfThree
{

    static void Main()
    {
        Console.Write("Enter first integer (positive or negative): ");
        int firstInt = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer (positive or negative): ");
        int secondInt = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer (positive or negative): ");
        int thirdInt = int.Parse(Console.ReadLine());
        
        int sign = 0;       //a variable to represent the resulting sign

        if (firstInt == 0 || secondInt == 0 || thirdInt == 0) // if any of the input numbers is zero, print the result and terminate the program
        {
            Console.WriteLine("The product is zero!");
            return;
        }
        if (firstInt > 0)
        {
            sign = sign + 1;
        }
        if (secondInt > 0)
        {
            sign = sign + 1;
        }
        if (thirdInt > 0)
        {
            sign = sign + 1;
        }

        if (sign == 1 || sign == 3)
        {
            Console.WriteLine("The product is a POSITIVE number.");
        }
        if (sign == 2 || sign == 0)
        {
            Console.WriteLine("The product is a NEGATIVE number.");
        }


    }
}