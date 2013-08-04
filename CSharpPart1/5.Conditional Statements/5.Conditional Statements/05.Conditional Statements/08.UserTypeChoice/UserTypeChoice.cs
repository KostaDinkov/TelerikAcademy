/*
 * Lecture 5 : Conditional Statements
 * Problem 8 : Write a program that, depending on the user's
 *              choice inputs int, double or string variable. 
 *              If the variable is integer or double, increases 
 *              it with 1. If the variable is string, appends "*" 
 *              at its end. The program must show the value 
 *              of that variable as a console output. 
 *              Use switch statement.
 */              


using System;

class UserTypeChoice
{
    static void Main()
    {
        Console.Write("Choose the data type for the input as follows:\n" +
                          "Enter 1 for int\n"+
                          "Enter 2 for double\n"+
                          "Enter 3 for string\n" +
                          ">>> ");
        
        switch(int.Parse(Console.ReadLine()))
        {
            case 1:
                Console.Write("Enter value : ");
                int userInt = int.Parse(Console.ReadLine());
                Console.WriteLine("Result : "+ (userInt+1));
                break;
            case 2:
                Console.Write("Enter value : ");
                double userDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("Result : " + (userDouble + 1));
                break;
            case 3:
                Console.Write("Enter value : ");
                string userStr = Console.ReadLine();
                Console.WriteLine("Result : " + userStr + "*");
                break;
                }

    }
}

