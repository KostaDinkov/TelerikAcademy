//Lecture 2: Primitive Data Types And Variables
//Problem 3: Write a program that safely compares 
            //floating-point numbers with precision of 0.000001. 
            //Examples:(5.3 ; 6.01) - false;  (5.00000001 ; 5.00000003) - true


using System;

class FloatCompare
{
    static void Main()
    {
        float floatNum1;                                           
        float floatNum2;                                           
        string compare;                                             //A string used to represent the result from the number comparison
        
        try                                                         // Try to get a valid input form the user
        {
            Console.Write("Enter a float number 1: ");                  
            floatNum1 = float.Parse(Console.ReadLine());
            
            Console.Write("Enter a float number 2: ");
            floatNum2 = float.Parse(Console.ReadLine());
        }
        catch (FormatException)                                     //If the input is not valid, i.e not a value 
        {                                                           //in the range of the float data type
            Console.WriteLine("Invalid Input...\nTerminating!\n");  //then print a message "Invalid input..." etc.
            return;
        }
        
        if (floatNum1 == floatNum2)                                 //Simple "if-else" check
        {
            compare = "equal to";
        }
        else if (floatNum1 < floatNum2)
        {
            compare = "lesser than";
        }
        else
        {
            compare = "greater than";
        }
        
        Console.WriteLine("Float number 1({0}) is {1} Float number 2({2})",floatNum1,compare,floatNum2);
        }
}

