//Lecture 3 : Operators And Expressions
//Problem 1 : Write an expression that checks if given integer is odd or even

using System;

class OddCheck
{
    static void Main()
    {
        int number=0;
        Console.WriteLine("Enter an integer to be checked:");
        
        try
        {
            number = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Not a valid input : ");
            return;            
        }
        
        if (number % 2 == 0)
        {
            Console.WriteLine("The number {0} is even.", number);
        }
        else
        {
            Console.WriteLine("The number {0} is odd.", number);
        }
        
        //A simpler version without the try-catch validation:
        
        //bool isOdd = number % 2 != 0;
        //Console.WriteLine("Is the number odd? : " + isOdd);
       
    }
}

