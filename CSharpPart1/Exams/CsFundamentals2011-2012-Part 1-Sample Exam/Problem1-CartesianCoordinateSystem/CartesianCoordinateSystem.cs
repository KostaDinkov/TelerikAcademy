﻿using System;


class CartesianCoordinateSystem
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        if (x==0 && y==0)
        {
            Console.WriteLine(0);
        }
        if (x==0 && y!=0)
        {
            Console.WriteLine(5);
        }
        if (x!=0 && y ==0)
        {
            Console.WriteLine(6);
        }
        if (x>0)
        {
            if (y>0)
            {
                Console.WriteLine(1);
            }
            if (y<0)
            {
                Console.WriteLine(4);
            }

        }
        if (x<0)
        {
            if (y>0)
            {
                Console.WriteLine(2);
            }
            if (y<0)
            {
                Console.WriteLine(3);
            }
        }
    }
}

