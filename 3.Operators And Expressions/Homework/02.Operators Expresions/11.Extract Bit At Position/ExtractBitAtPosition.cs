/*
 * Lecture 3 : Operators And Expressions
 * Problem 11: Write an expression that extracts 
 *              from a given integer i the value of a 
 *              given bit number b. 
 *              Example: i=5; b=2  value=1.
 */              

using System;

class ExtractBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int input = int.Parse(Console.ReadLine());

        Console.Write("Enter the bit position to extract from: ");
        int position = int.Parse(Console.ReadLine());

        int bitMask = 1 << position;               //Setting the value 1 at "position" in the bitMask.
        int result = input & bitMask;              //Aplying bitwise & to the input and the bitMask


        //A more visual representation of the & operation for educational purposes ;)
        Console.WriteLine("Binary representation of the operation:\n");
        Console.WriteLine("Input             :".PadRight(20) + Convert.ToString(input, 2).PadLeft(32, '0'));
        Console.WriteLine("Aplying bitwise & :" + "&".PadLeft(Math.Abs(position - 33)));
        Console.WriteLine("Position to check :".PadRight(20) + Convert.ToString(bitMask, 2).PadLeft(32, '0'));
        Console.WriteLine("Equals            :" + "=".PadLeft(Math.Abs(position - 33)));
        Console.WriteLine("Result            :".PadRight(20) + Convert.ToString(result, 2).PadLeft(32, '0')+"\n");
        
        Console.WriteLine("The bit at position {0} has a value of : {1}\n", position%32, result >> position);//Shifting back the value from bit at "position"
                                                                                                          //Only two possible values, 1 and 0
    }
}

