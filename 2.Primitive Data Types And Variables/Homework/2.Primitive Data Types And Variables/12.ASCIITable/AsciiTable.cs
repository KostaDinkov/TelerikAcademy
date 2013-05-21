/*
* Lecture  2: Primitive Data Types And Variables
* Problem 12: Find online more information about ASCII 
*           (American Standard Code for Information Interchange) 
*           and write a program that prints the entire ASCII table of 
*           characters on the console.
*/

using System;

class AsciiTable
{
    static void Main()
    {
        Console.Write("Decimal".PadRight(10));          //making two "columns".One for the decimal code
        Console.WriteLine("Character\n");               //and one for the charater representation of the code
        
        for (int i = 0; i < 128; i++)                   //A loop that repeats 128 times, as is the number of ASCII codes
        {
            Console.Write(i.ToString().PadRight(10));   //Using the .ToString() method because .PadRight() doesnt work with ints
            Console.WriteLine((char)i);                 //simple typecasting to represent the int as its coresponding char
        }
               
    }
}

