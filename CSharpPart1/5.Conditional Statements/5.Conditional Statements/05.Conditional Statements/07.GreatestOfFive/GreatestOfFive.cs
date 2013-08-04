/*
 * Lecture 5 : Conditional Statements
 * Problem 7 : Write a program that finds the 
 *              greatest of given 5 variables.
 */ 

//NOTE: Since the specification doesn't say what is the type of the variables 
//and if they should vary, I chose to work with the double type.            


using System;

class GreatestOfFive
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers, each on a new row:");
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());
        double fourthNum = double.Parse(Console.ReadLine());
        double fifthNum = double.Parse(Console.ReadLine());

        double biggest = 0;

        if (firstNum>biggest)
        {
            biggest = firstNum;
        }
        if (secondNum > biggest)
        {
            biggest = secondNum;
        }
        if (thirdNum > biggest)
        {
            biggest = thirdNum;
        }
        if (fourthNum > biggest)
        {
            biggest = fourthNum;
        }
        if (fifthNum > biggest)
        {
            biggest = fifthNum;
        }
        Console.WriteLine("The biggest number is: "+ biggest);

    }
}

