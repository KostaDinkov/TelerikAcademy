/*
 * Lecture 3 : Operators And Expressions
 * Problem 3 : Write an expression that calculates 
 *             rectangle’s area by given width and height.             
 */
 
using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("Enter rectangle's height: ");
        int height = int.Parse(Console.ReadLine());
        
        Console.Write("Enter rectangle's width: ");
        int width = int.Parse(Console.ReadLine());
        
        int area = height * width;
        Console.WriteLine("The area of the rectangle is {0}.",area);
    }
}

