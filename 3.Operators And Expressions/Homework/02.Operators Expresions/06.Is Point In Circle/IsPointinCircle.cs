/*
 * Lecture 3 : Operators And Expressions
 * Problem 6 : Write an expression that checks if 
 *             given point (x,  y) is within a circle K(O, 5).
 */             


using System;

class IsPointinCircle
{
    static void Main()
    {
        int circleRadius = 5;                                   //The radius of the circle. Change for bigger cirkle                            

        Console.Write("Enter x coordinate for the point:");
        float pointX = float.Parse(Console.ReadLine());        //The x coordinate of the point

        Console.Write("Enter y coordinate for the point:");    //The y coordinate of the point
        float pointY = float.Parse(Console.ReadLine());

        bool isPointIn = (Math.Pow(pointX, 2) + Math.Pow(pointY, 2) <= Math.Pow(circleRadius, 2));
        
        //using the Pythagorean theorem.The distance  from the center of the circle(0,0) to
        //the point (x, y) is equal to the hypothenuse of a right angle triangle with sides
        // x and y. So if that distance - Hypothenuse is greater than the circles radius - 
        //the point is outside. And if the hypothenuse is less or equal to the radius, the point is inside
        //(or on) the circle                      
        
        Console.WriteLine("Is the point ({0},{1}) in the circle ((0,0),{2}) ? : " + isPointIn, pointX, pointY, circleRadius);
    }
}

