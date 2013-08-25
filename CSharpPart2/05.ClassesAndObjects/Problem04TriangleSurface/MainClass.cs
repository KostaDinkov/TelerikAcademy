/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 5: Objects and Classes
 * Problem 4: Write methods that calculate the surface of 
 *              a triangle by given:
 *              Side and an altitude to it; Three sides; 
 *              Two sides and an angle between them. 
 *              Use System.Math.
 */

using System;

namespace Problem04TriangleSurface
{
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("Choose a method for calculating the surface  of a triangle: ");
            Console.WriteLine("1. By given three sides");
            Console.WriteLine("2. By given side and an altitude to it");
            Console.WriteLine("3. By given two sides and an angle between them");
            Console.Write("Enter 1, 2 or 3 and press Enter:");
            int choice = int.Parse(Console.ReadLine());
            double area;
            double sideA;
            double sideB;
            double sideC;
            switch(choice)
            {
                case(1):
                    Console.Write("Enter side a : ");
                    sideA = double.Parse(Console.ReadLine());
                    Console.Write("Enter side b : ");
                    sideB = double.Parse(Console.ReadLine());
                    Console.Write("Enter side c : ");
                    sideC = double.Parse(Console.ReadLine());
                    area = GetTriangleArea(sideA, sideB, sideC);
                    Console.WriteLine("The area is : {0}", area);
                    break;
                case(2):
                    Console.Write("Enter a side : ");
                    sideA = double.Parse(Console.ReadLine());
                    Console.Write("Enter a the altitude : ");
                    double alt = double.Parse(Console.ReadLine());
                    area = GetTriangleArea(sideA, alt);
                    Console.WriteLine("The area is : {0}", area);
                    break;
                case(3):
                    Console.Write("Enter side a : ");
                    sideA = double.Parse(Console.ReadLine());
                    Console.Write("Enter side b : ");
                    sideB = double.Parse(Console.ReadLine());
                    Console.Write("Enter side the included angle between a and b : ");
                    float angleAB = float.Parse(Console.ReadLine());
                    area = GetTriangleArea(sideA, sideB, angleAB);
                    Console.WriteLine("The area is : {0}", area);
                    break;
                default:
                    break;

                    
            }
        }

        static double GetTriangleArea(double sideA, double altA)
        {
            return (sideA * altA) / 2;
        }
        static double GetTriangleArea(double sideA, double sideB, double sideC)
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
        static double GetTriangleArea(double sideA, double sideB, float angleAB)
        {
            double radians = (angleAB*Math.PI)/180;
            Console.WriteLine(Math.Sin(radians));
            return (sideA * sideB * (Math.Sin(radians))) / 2;
        }
    }
    
}
