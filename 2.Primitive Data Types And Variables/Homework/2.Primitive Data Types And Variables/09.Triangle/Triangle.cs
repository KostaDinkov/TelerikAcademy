//Lecture 2: Primitive Data Types And Variables
//Problem 9: Write a program that prints an isosceles triangle of 9 
             //copyright symbols ©. Use Windows Character Map to find 
             //the Unicode code of the © symbol. Note: the © symbol 
             //may be displayed incorrectly.


using System;
using System.Text;

class Triangle
{
    static void Main()
    {   
        int rows = 3;                                           //Set the height of the triangle. Change to set custom height.
        int numSymbols = 1;                                     //Set the number of symbols on the first row. Do Not change this
        int numSpaces=rows;                                     //Set the number of empy spaces on the first row. Do not change this
        char symbol = '\u00a9';                                 //Set the unicode char to be displayed. Change this to use a different symbol to draw the shape
        
        //Uncoment the following line to try to display the correct copyright symbol. It may not work depending on what font is used by the console
        //Console.OutputEncoding = Encoding.UTF8;               
          
        
        for (int i = 0; i < rows; i++)                          //A simple loop that repeats "rows" number of times                                                
        {                           
            Console.WriteLine(new string(symbol,numSymbols).PadLeft(numSpaces));  //Using the string.PadLeft() method for the leading blank spaces on each row  
            numSpaces++;                                                          //on each itteration of the loop (i.e on each new row) blank spaces increase by 1                                                                                                  
            numSymbols += 2;                                                      //and the number of symbols increase by 2
        }
        
    }
}

