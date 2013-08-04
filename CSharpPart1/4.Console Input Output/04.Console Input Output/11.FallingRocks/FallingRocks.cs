using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


class FallingRocks
{
    static void Main()
    {
        Console.WindowHeight = 45;
        Console.WindowWidth = 90;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
        Console.CursorVisible = false;
        int speed = 100;
        Random randomGenerator = new Random();
        List<FallingObject> fallingObjects = new List<FallingObject>();
        Car myCar = new Car();
        myCar.x = Console.WindowWidth / 2;
        myCar.y = Console.WindowHeight - 2;
        myCar.c = 'X';
        myCar.color = ConsoleColor.Yellow;


        while (true)
        {
            // draw Rocks
            FallingObject rock = new FallingObject();
            rock.color = ConsoleColor.Red;
            rock.x = randomGenerator.Next(1, Console.WindowWidth);
            rock.y = 1;
            rock.c = '#';
            fallingObjects.Add(rock);
            
            List<FallingObject> newList = new List<FallingObject>();
            
            for (int i = 0; i < fallingObjects.Count; i++)
            {
                FallingObject oldRock = fallingObjects[i];
                FallingObject newRock = new FallingObject();
                clear(oldRock.x, oldRock.y);
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.c = oldRock.c;
                newRock.color = oldRock.color;
                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);    
                }
                     
                
            }
            fallingObjects = newList;
            foreach (FallingObject fRock in fallingObjects)
            {
                
                printAt(fRock.x, fRock.y, fRock.c, fRock.color);
            }
            //Move Car
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                clear(myCar.x, myCar.y);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (myCar.x - 1 >= 0)
                    {
                        myCar.x -= 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (myCar.x + 1 < Console.WindowWidth)
                    {
                        myCar.x += 1;
                    }
                }

            }

            //draw Objects
            printAt(myCar.x, myCar.y, myCar.c, myCar.color);
            
            
            


            
            //slowDown
            Thread.Sleep(speed);
        }

    }
    struct FallingObject
    {
        public int x;
        public int y;
        public ConsoleColor color;
        public char c;
    }
    struct Car
    {
        public int x;
        public int y;
        public ConsoleColor color;
        public char c;
    }
    static void printAt(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void clear(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(" ");
    }
}
    

