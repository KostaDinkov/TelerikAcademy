/*
 * Lecture 3 : Operators And Expressions
 * Problem 8 : Write an expression that calculates trapezoid's 
 *             area by given sides a and b and height h.
 */             

using System;

class TrapeziodArea
{
    static void Main()
    {
        //assuming user input is valid. No making a validaion checks.
        
        Console.Write("Enter side a:");
        float sideA = float.Parse(Console.ReadLine());
        Console.Write("Enter side b:");
        float sideB = float.Parse(Console.ReadLine());
        Console.Write("Enter height h:");
        float heightH = float.Parse(Console.ReadLine());

        float area = ((sideA + sideB) / 2) * heightH;               
        Console.WriteLine("The area of the trapezoid is:" + area);

    }
}

