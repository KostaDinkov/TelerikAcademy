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
        Console.WriteLine("Enter rectangle's height:");
        int height = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter rectangle's width:");
        int width = int.Parse(Console.ReadLine());
        
        int area = height * width;
        Console.WriteLine("Te area of the rectangle is {0}.",area);
    }
}

