using System;

    class BinaryDigitsCount
    {
        static void Main()
        {
            int B = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < N; i++)
            {
                uint input = uint.Parse(Console.ReadLine());
                int counter = 0;
                while (input>0)
                {
                    if (B==1)
                    {
                        if ((input & B) == B)
                        {
                            counter++;
                        }
                        
                    }
                    else
                    {
                        if (input % 2 ==0)
                        {
                            counter++;
                        }
                    }
                    input = input >> 1;
                }
                Console.WriteLine(counter);
            }
        }
    }

