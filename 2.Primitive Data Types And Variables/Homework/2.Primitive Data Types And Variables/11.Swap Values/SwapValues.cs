//Lecture  2: Primitive Data Types And Variables
//Problem 11: Declare  two integer variables and assign 
              //them with 5 and 10 and after that exchange their values.
 
using System;

class SwapValues
{
    static void Main()
    {
        int num1 = 5;
        int num2 = 6;
        
        int tmp = num1;             //declaring a tmp variable to "remember" the value of num1
        num1 = num2;                
        num2 = tmp;
        Console.WriteLine("num1 = {0}, num2 = {1}.",num1,num2 );

    }
}

