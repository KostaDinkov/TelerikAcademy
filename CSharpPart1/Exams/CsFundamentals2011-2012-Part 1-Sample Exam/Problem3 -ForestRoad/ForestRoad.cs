using System;

class ForestRoad
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int position = 0;
        for (int i = 0; i < width; i++)
        {
            
            for (int j = 0; j < width; j++)
            {
                if (j==position)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');    
                }
                
            }
            Console.WriteLine();
            position++;
        }
        position-=2;
        for (int i = width-2; i >= 0; i--)
        {
            for (int j = 0; j < width; j++)
            {
                if (j==position)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');    
                }
                
            }
            Console.WriteLine();
            position--;
        }
    }
}

