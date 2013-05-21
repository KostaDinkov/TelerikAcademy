/*
 * Lecture 3 : Operators And Expressions
 * Problem 10: Write a boolean expression that returns if the bit at position p 
 *            (counting from 0) in a given integer number v has value of 1. 
 *            Example: v=5; p=1  false.
 */


using System;

class CheckBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter a number to be checked: ");
        int input = int.Parse(Console.ReadLine());

        Console.Write("Enter the bit position to be checked: ");
        int position = int.Parse(Console.ReadLine());

        int bitMask = 1 << position;               //Setting the value 1 at "position" in the bitMask.
        int result = input & bitMask;              //Aplying bitwise & to the input and the bitMask

        Console.WriteLine("The bit at position {0} has a value of 1:" + (result >> position == 1) + "\n", position);//Shifting back the value from bit at "position"
                                                                                                      //Only two possible values, 1 and 0
        
        
        //A more visual representation of the & operation for educational purposes ;)
        Console.WriteLine("Input             :".PadRight(20)+Convert.ToString(input, 2).PadLeft(32, '0'));
        Console.WriteLine("Aplying bitwise & :" + "&".PadLeft(Math.Abs(position - 33)));
        Console.WriteLine("Position to check :".PadRight(20)+Convert.ToString(bitMask,2).PadLeft(32,'0'));
        Console.WriteLine("Equals            :" + "=".PadLeft(Math.Abs(position - 33)));
        Console.WriteLine("Result            :".PadRight(20)+Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}

