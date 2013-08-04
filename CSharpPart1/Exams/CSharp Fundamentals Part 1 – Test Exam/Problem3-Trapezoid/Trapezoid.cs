using System;

    class Trapezoid
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            //first row
            Console.Write(new String('.',N));
            Console.Write(new String('*', N));
            Console.WriteLine();
            //middle part
            int starPosition = N-1;
            for (int height = N - 1; height > 0; height--)
            {
                for (int i = 0; i < N*2; i++)
                {
                    if (i == starPosition || i == (N * 2) - 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                    


                }
                Console.WriteLine();
                starPosition--;
            }
            //last row
            Console.WriteLine(new String('*',N*2));
            

        }
    }

