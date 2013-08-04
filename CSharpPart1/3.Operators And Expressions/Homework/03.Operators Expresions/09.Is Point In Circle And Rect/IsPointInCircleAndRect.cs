/*
 * Lecture 3 : Operators And Expressions
 * Problem 9 : Write an expression that checks for given point (x, y) 
 *             if it is within the circle K( (1,1), 3) and out of the 
 *             rectangle R(top=1, left=-1, width=6, height=2).
 */             


using System;

class IsPointInCircleAndRect
{
    
    static void Main()
    {

        int circleRadius = 3;                                        //The radius of the circle. Change for bigger circle      
        int circleX = 1;                                             //Coordinate x of the circle's center
        int circleY = 1;                                             //Coordinate y of the circle's center
       
        Console.Write("Enter x coordinate for the point(int):");
        int pointX = int.Parse(Console.ReadLine());                  //The x coordinate of the point

        Console.Write("Enter y coordinate for the point(int):");     //The y coordinate of the point
        int pointY = int.Parse(Console.ReadLine());

        bool isPointIn = Math.Pow((pointX - circleX), 2) + Math.Pow((pointY - circleY), 2) <= Math.Pow(circleRadius, 2)
                         && ((pointX <-1 || pointX>5)||(pointY>1 || pointY<-1)); // if the point is  (left or right) or (above or below) 
                                                                                 //of the rectangle , then its not inside(or on) :)
        
        Console.WriteLine("The point is in the circle AND outside the rectangle: "+isPointIn);
        
    }
}

