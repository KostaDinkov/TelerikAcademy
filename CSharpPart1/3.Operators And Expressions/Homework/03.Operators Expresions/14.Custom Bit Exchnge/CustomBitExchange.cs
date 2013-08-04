/*
 * Lecture 3 : Operators and Expressions
 * Problem 14: Write a program that exchanges bits {p, p+1, …, p+k-1) 
 *             with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
 */


using System;
using System.Linq;

class BitExchange
{
    static void Main()
    {
        Console.Write("Input a number:");
        uint inputInt = uint.Parse(Console.ReadLine());                               //Read the input number
        Console.Write("Input the first bit position to be exchanged: ");
        int positionP = int.Parse(Console.ReadLine());                                //Read the first bit sequence position  
        Console.Write("Input the second bit position to be exchanged: ");
        int positionQ = int.Parse(Console.ReadLine());                                //Read the second bit sequence position  
        Console.Write("Enter the how many successive bit you want\n"+
                        "to exchange between positions:");
        int seqLen = int.Parse(Console.ReadLine());                                   //Read the lenght of the bit position sequence  
       
        string inputStr = Convert.ToString(inputInt, 2).PadLeft(32, '0');           //Convert Input to binary string representation with leading zeros 
        int[] inputArray = inputStr.Select(c => int.Parse(c.ToString())).ToArray(); //Create an array of ints from the string; example: {0,0,0,1,0,...,1,0}
        PrintValues(inputArray);                                                    //Display the values of the array                                                  
        int[] resultArray = (int[])inputArray.Clone();                              //Creating a copy of the input number array
        
        positionP = Math.Abs((positionP) - 31) - seqLen+1;                          //The positions adapted to corespond to the right indexes in the array
        positionQ = Math.Abs((positionQ) - 31) - seqLen+1;                          
        
        Array.Copy(inputArray,positionQ, resultArray, positionP, seqLen);          //Using  the Array.Copy method as decribed in  13.Bit Exchange Array project.
        Array.Copy(inputArray,positionP, resultArray, positionQ, seqLen);          //Note that exception will be thrown if the sum  of any of  the starting positions and the sequence lenght is   
                                                                                   //greater than 32 wich is the array's  and int type's lenght.                                                            
        PrintValues(resultArray);


    }
    //a helper function for displaying the values of an Array
    public static void PrintValues(Array myArr)
    {
        foreach (int i in myArr)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
}
