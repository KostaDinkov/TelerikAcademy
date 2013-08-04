/*
 * Lecture 4 : Console Input Output
 * Problem 7 : Write a program that gets a number n 
 *             and after that gets more n numbers and 
 *             calculates and prints their sum. 
 */             


using System;

class SumNumbers
{
    static void Main()
    {
        Console.Write("How many numbers do you want to sumarize ? :");
        int numCount = int.Parse(Console.ReadLine()); //the quantity of numbers to be added together
        float sum = 0;                                //a var to hold the addition result

        for (int i = 0; i < numCount; i++)                  //repeat the loop numCount number of times
        {
            Console.Write("Enter number {0}: ",i+1);        //on each itteration ask the user for a number and...
            float number = float.Parse(Console.ReadLine());
            sum = sum + number;                             //...add the input number   to the current sum        
        }
        Console.WriteLine("The SUM of the numbers is: "+sum);
    }
}

