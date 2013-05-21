/*
 * Lecture 3 : Operators And Expressions
 * Problem 12: We are given integer number n, value v (v=0 or 1) 
 *             and a position p. Write a sequence of operators that 
 *             modifies n to hold the value v at the position p from 
 *             the binary representation of n.
 */

using System;

class ExtractBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int input = int.Parse(Console.ReadLine());

        Console.Write("Enter the bit position to be midified: ");
        int position = int.Parse(Console.ReadLine());

        Console.Write("Enter a Value(1 or 0): ");
        string bitValue = Console.ReadLine();                                               //input to a string for later convenience

        char[] inputArray = (Convert.ToString(input, 2).PadLeft(32, '0')).ToCharArray();    //convert the input number to string with 
                                                                                            //binary representation of the number,
                                                                                            //then to char array of length 32 
        Console.WriteLine("Input :"+Convert.ToString(input, 2).PadLeft(32, '0'));           
        inputArray[Math.Abs(position - 31)] = bitValue[0];                                  //change the index of the aray at the coresponding
                                                                                            //position and assign the value of the users bitValue
        Console.WriteLine("Result:"+new string(inputArray));
        
        int result = Convert.ToInt32(new string(inputArray), 2);                            //convert the aray back to int and display the new decimal value
        Console.WriteLine("Result in Decimal: " + result);

    }
}


