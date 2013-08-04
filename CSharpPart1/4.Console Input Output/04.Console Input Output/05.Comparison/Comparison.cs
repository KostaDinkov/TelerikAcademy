/*
 * Lecture 4 : Console Input Output
 * Problem 5 : Write a program that gets two numbers 
 *              from the console and prints the greater of 
 *              them. Don’t use if statements
 */              

using System;

class Comparison
{
    static void Main()
    {
        Console.Write("Insert the first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Insert the second number: ");
        int secondNum = int.Parse(Console.ReadLine());

        //variant A - wich resembles an "if" statement but can't check if they are equal
        int resultA = firstNum > secondNum ? firstNum : secondNum;
        Console.WriteLine("Variant A - The greater number is : "+ resultA);

        //variant B - the easier way - 
        //Math.Max(int,int) - returns the greater of two values
        int resultB = Math.Max(firstNum, secondNum);
        Console.WriteLine("Variant B - The greater number is : "+ resultB);
    }
}

