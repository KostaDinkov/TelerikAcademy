﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HappyFaces
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("o o        . .");
        Console.WriteLine(" )          ) ");
        Console.WriteLine("___        ###");
        for (int i = 0; i < 20; i++)
        {
            Console.MoveBufferArea(i + 11, i, 3, 3, i + 12, i + 1,
                'x', ConsoleColor.Red, ConsoleColor.White);
            Console.MoveBufferArea(i, i, 3, 3, i + 1, i + 1);
            Console.Beep((i + 10) * 100, 100);
        }
        Console.SetCursorPosition(0, 23);
        Console.ResetColor();
    }
}
