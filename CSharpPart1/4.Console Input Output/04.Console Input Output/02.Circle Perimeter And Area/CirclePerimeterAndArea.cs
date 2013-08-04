/*
 * Lecture 4 : Console Input Output
 * Problem 2 : Write a program that reads the 
 *              radius r of a circle and prints 
 *              its perimeter and area.
 */              
 
using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter circle's radius: ");
        int radius = int.Parse(Console.ReadLine());
        float pi = (float)Math.PI;
        float perimeter = 2 * pi * radius;
        float area = pi * radius * radius;
        Console.WriteLine("The circle has a perimeter of {0} and an area of {1}",perimeter,area);
        Console.WriteLine();

    }
}

