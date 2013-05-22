/*
 * Lecture 3 : Operators and Expressions
 * Problem 23: Write a program that exchanges bits 3, 4 
 *             and 5 with bits 24, 25 and 26 of given 
 *             32-bit unsigned integer.
 */


using System;


class BitExchange
{
    static void Main()
    {
        Console.Write("Input a positive ineger:");
        uint inputNum = 0;
        bool isValid = uint.TryParse(Console.ReadLine(), out inputNum); //Try to convert the input string to uint
        Console.WriteLine(isValid? Convert.ToString(inputNum,2)
                                          .PadLeft(32,'0'):"Invalid Input.");//If input is valid, print the number in binary, else 
                                                                             //print Invalid Input
        
        byte juniorPos = (byte)((inputNum >> 3) & 7);                        //shift the bits of the input 3 positions left and then apply "&"
                                                                             //with 7 wich is "...000111" to "extract" the values at that positions *1 
        byte seniorPos = (byte)((inputNum >> 24) & 7);                       //The same as above for position 24
        
        byte bitMask = (byte)(juniorPos ^ seniorPos);                        //for more clarification of the procedure read below at *2 
        inputNum = (uint)(inputNum ^ (bitMask << 24));
        inputNum = (uint)(inputNum ^ (bitMask << 3));
        Console.WriteLine(Convert.ToString(inputNum,2).PadLeft(32,'0'));


    }
    
}
/* 1.Note: We use the number 7 ("..000111") as a bitmask because we need to extract from 3 succesive positions
 * all at once. If we needed 2 positions we would've used the number 3 - "...0011".And if we 
 * needed 4 positions then 15 - "...0001111"
 * 2. For the position exchange we use the following idea: Let C is a XOR result of A and B ( in our case A = the values
 * of bits  3,4,5 and B = bits  24,25,26). Then  we get A XOR C = B and  B XOR C = A.In other words if we appply
 * the value of our bitMask to the inputNum at positiotions 24,25,16 we end up with the values of positions 3,4,5 at 24,25,26.
 * I hope that this example doesn't cause more confusion than it actually helps ;)
 */
