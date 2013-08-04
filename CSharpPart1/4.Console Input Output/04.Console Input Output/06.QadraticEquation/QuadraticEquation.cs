/*
 * Lecture 4 : Console Input Output
 * Problem 6 : Write a program that reads the coefficients 
 *              a, b and c of a quadratic equation ax2+bx+c=0 
 *              and solves it (prints its real roots).
 */              


using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program takes the coefficients a,b and c, \nand solves equation of the type ax*x + bx + c = 0");
        Console.Write("Enter coefficient a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter coefficient b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter coefficient c: ");
        float c = float.Parse(Console.ReadLine());
        float discriminant = b * b - 4 * a * c;
        float x;  //when there is only 1 root
        float x1,x2 ; //when there are 2 roots
        float img;  // when the roots are complex numbers, img will represents the imaginary part

        if (discriminant == 0) // if the discriminant equals zero - there is 1 root  
        {
            x = (-b + (float)Math.Sqrt(discriminant)) / 2 * a;
            Console.WriteLine("The quadratic equation has 1 root and it is : x = " + x);
        }
        else if (discriminant > 0)// if discriminant is greater than zero - there are two roots 
        {
            x1 = (-b + (float)Math.Sqrt(discriminant)) / 2 * a;
            x2 = (-b - (float)Math.Sqrt(discriminant)) / 2 * a;
            Console.WriteLine("The quadratic equation has 2 real number roots and they are : x1= {0} , x2= {1} ",x1, x2);
        }
        else  // if discriminant is negative - there are two complex number solutions
        {
            discriminant = -discriminant;
            x = -b / (2 * a);
            img = (float)Math.Sqrt(discriminant) / (2 * a);
            Console.WriteLine("The quadratic equation has two imaginary solutions: {0} + {1}i or {2} - {3}i", x, img, x, img);
        }


    }
}

