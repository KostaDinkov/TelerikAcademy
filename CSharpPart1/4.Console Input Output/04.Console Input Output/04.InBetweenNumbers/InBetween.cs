/*
 * Lecture 4 : Console Input Output
 * Problem 4 : Write a program that reads two positive 
 *              integer numbers and prints how many 
 *              numbers p exist between them such that 
 *              the reminder of the division by 5 is 0 
 *              (inclusive). Example: p(17,25) = 2.
 */              

//Note: using custom number for the divisor instead of just "5"
//and also displaying all the numbers that satisfy the specification

using System;
using System.Collections.Generic;

class InBetween
{
    static void Main()
    {
        Console.WriteLine("This program calculates how many numbers\n"+
                            "in the range between to given positive integers\n"+
                            "are divisable by the number n.\n");
        Console.Write("Enter first positive integer: ");
        uint firstInt = uint.Parse(Console.ReadLine());
        Console.Write("Enter second positive integer: ");
        uint secondInt = uint.Parse(Console.ReadLine());
        Console.Write("Enter the divisor (n): ");
        uint divisor = uint.Parse(Console.ReadLine());
        

        uint smallerNum = (firstInt < secondInt ? firstInt : secondInt);  //check wich of the provided numbers is smaller
        uint greaterNum = (firstInt > secondInt ? firstInt : secondInt);  //and asign it to a new variable  
        
        uint counter = 0;                                                 //a variable to count the numbers that are divisable by n  
        
        uint range = greaterNum - smallerNum;                             
        uint iterable = smallerNum;                                       //a var for all the numbers that need to be checked 
        List<uint> results = new List<uint>();                            //a list to store the numbers that pass the check  
        for (uint i = 0; i <= range; i++)                                 //the loop repeats (range+1) number of times 
        {
            if (iterable % divisor == 0)                                  //if the number to be checked is divisable by n...    
            {
                counter++;                                                //...then the counter increases by 1     
                results.Add(iterable);
            }
            iterable++;                                                   // go to the next number to be checked  
        }
        Console.WriteLine();
        Console.WriteLine("Number of integers divisable by {3} in the range {0} - {1} : {2}", smallerNum, greaterNum, counter,divisor);

        Console.WriteLine("They are:");
        foreach (uint result in results)                                 // print all the numbers that pass the check.
        {
            Console.Write(result+",");
        }
        Console.WriteLine();
        
    }
}
