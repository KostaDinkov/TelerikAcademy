/*
 * Lecture 3 : Operators And Expressions
 * Problem 5 : Write a boolean expression for finding if the bit 3 
 *              (counting from 0) of a given integer is 1 or 0.
 */              


using System;

class CheckBit3
{
    static void Main()
    {
        Console.Write("Enter an integer : ");
        
        int inputNum = int.Parse(Console.ReadLine());                   //Asuming the users input is of a valid format and representing it as a binary number
        Console.WriteLine("The input in binary is : ".PadRight(35) + Convert.ToString(inputNum, 2).PadLeft(32, '0'));
        
        int mask = 8;                                                   //creating a mask number that has the digit 1 only at its 3rd bit.Everything else is zeros
        Console.WriteLine("Creating mask for bit 3 :".PadRight(35)+Convert.ToString(mask, 2).PadLeft(32,'0'));
        
        int result = inputNum & mask;                                   //Aplying the & operator to both the input and the mask.
        Console.WriteLine("Aplying the & operator to both :".PadRight(35) + Convert.ToString(result, 2).PadLeft(32, '0'));
        
        result = result >> 3;                                           //shifting the result 3 places to the right.
        Console.WriteLine("Shifting result 3 places right:".PadRight(35) + Convert.ToString(result, 2).PadLeft(32, '0'));
        
        bool isOne = result == 1;                                       //if the shifted result is equal to 1, than the 3rd bit of the input was indeed a 1. 
        Console.WriteLine("Is bit 3 a 1? :".PadRight(35) + isOne.ToString().PadLeft(32));

    }
}

