/*
 * Lecture 3 : Operators And Expressions
 * Problem 2 : Write a boolean expression that checks 
 *             for given integer if it can be divided 
 *             (without remainder) by 7 and 5 in the 
 *             same time.             
 */

using System;

class DivisableBy5AND7
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it is divisable by both 5 and 7");
        
        int number =int.Parse(Console.ReadLine());              //Assuming that the user input is valid
        
        bool isDivisable = number % 7 == 0 && number % 5 == 0;  //if the reminder of the division operation of the input number and the numbers 5 and 7 is 0
                                                                //then the input number is divisable by both numbers
        Console.WriteLine(isDivisable ? "The number " + number + " IS divisable by 5 AND 7." : "The number " + number + " IS NOT divisable by 5 AND 7.");
        
        //Another ooption is to check if the input is divisable by 35(then it will also be divisible by 5 and 7):
        //bool isDivBy35 = number % 35== 0;
        //Console.WriteLine("Is the number Divisable by 35 ? : "+isDivBy35);
    }
}

