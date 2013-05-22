/*
 * Lecture 3 : Operators and Expressions
 * Problem 23: Write a program that exchanges bits 3, 4 
 *             and 5 with bits 24, 25 and 26 of given 
 *             32-bit unsigned integer.
 */


/* Note: This code uses a modified version of the code in "13.Bit Exchange Bitwise" project.
 * For more info on some of the ideas and procedures used you can read there.
 */

using System;


class BitExchange
{
    static void Main()
    {
        Console.Write("Input a positive ineger: ");
        uint inputNum = 0;
        bool isValid = uint.TryParse(Console.ReadLine(), out inputNum);
        Console.WriteLine(isValid ? Convert.ToString(inputNum, 2).PadLeft(32, '0') : "Invalid Input. ");
        Console.Write("Enter 1st position to be exchanged: ");
        byte positionA = byte.Parse(Console.ReadLine());    
        Console.Write("Enter second position to be exchanged: ");
        byte positionB = byte.Parse(Console.ReadLine());
        
        Console.Write("Enter the lenght of the bit sequence to be exchanged: ");
        byte seqLen = byte.Parse(Console.ReadLine());       //The lenght of the sequence of bits
        int bitLenght =0;                                   //The representation of the lenght of bits in binary - "...0001","0011","...0111", etc.
        
        for (int i = 0; i < seqLen; i++)                    // Read below for clarification          
        {
            bitLenght = (bitLenght << 1) ^ 1;
        }
                
        int juniorPos = (byte)((inputNum >> positionA) & bitLenght);                        
        int seniorPos = (byte)((inputNum >> positionB) & bitLenght);                       
        byte bitMask = (byte)(juniorPos ^ seniorPos);                        
        inputNum = (uint)(inputNum ^ (bitMask << positionA));
        inputNum = (uint)(inputNum ^ (bitMask << positionB));
        Console.WriteLine(Convert.ToString(inputNum, 2).PadLeft(32, '0'));


    }

}

 /*On each itteration of the loop we shift bitLenght(wich initially is 0) 1 position to the left
  * then  we add a 1 at it's right most bit. We do that seqLen number of times. So if we
  * have a bit sequence lenght of 4 we will get "...0001111". 
  */ 
