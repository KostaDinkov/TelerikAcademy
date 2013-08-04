/*
 * Lecture 5 : Conditional Statements
 * Probelm 1 : Write an if statement that examines two 
 *              integer variables and exchanges their 
 *              values if the first one is greater 
 *              than the second one.
 */

using System;

class Program
{
     
    static void Main()
    {
        Console.Write("Enter first integer : ");
        int firstInt = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int secondInt = int.Parse(Console.ReadLine());

        if (firstInt > secondInt)
        {
            int tmp = secondInt;   //temp var for storing the secondInt value
            secondInt = firstInt;
            firstInt = tmp;                
        }
        else if (firstInt == secondInt)
        {
            Console.WriteLine("The two integers are equal.");
            return;
        }

        Console.WriteLine("Here are the numbers sorted from smaller to greater:\n{0} , {1}", firstInt, secondInt);
    }
}

