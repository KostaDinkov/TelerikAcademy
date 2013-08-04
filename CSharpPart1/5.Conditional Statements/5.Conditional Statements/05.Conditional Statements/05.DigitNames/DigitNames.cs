/*
 * Lecture 5 : Conditional Statements
 * Problem 5 : Write program that asks for a 
 *              digit and depending on the input 
 *              shows the name of that digit (in English) 
 *              using a switch statement.
 */              


using System;

class DigitNames
{
    static void Main()
    {
        Console.WriteLine("Enter a digit (0-9): ");
        byte digit = byte.Parse(Console.ReadLine());

        switch (digit)
        {
            case 0: 
                Console.WriteLine("The digit is ZERO"); 
                break;
            case 1:
                Console.WriteLine("The digit is ONE");
                break;
            case 2: Console.WriteLine("The digit is TWO");
                break;
            case 3:
                Console.WriteLine("The digit is THREE");
                break;
            case 4:
                Console.WriteLine("The digit is FOUR");
                break;
            case 5:
                Console.WriteLine("The digit is FIVE");
                break;
            case 6: 
                Console.WriteLine("The digit is SIX");
                break;
            case 7: 
                Console.WriteLine("The digit is SEVEN");
                break;
            case 8: 
                Console.WriteLine("The digit is EIGHT");
                break;
            case 9: 
                Console.WriteLine("The digit is NINE");
                break;
            default: 
                Console.WriteLine("Invalid input");
                break;


        }
    }
}

