using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Tribonacci
{
    class Tribonacci
    {
        static void Main()
        {
            BigInteger firstNum = int.Parse(Console.ReadLine());
            BigInteger secondNum = int.Parse(Console.ReadLine());
            BigInteger thirdNum = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            BigInteger sum = 0;
            switch (count)
            {
                case (1): Console.WriteLine(firstNum);
                    break;
                case (2): Console.WriteLine(secondNum);
                    break;
                case (3): Console.WriteLine(thirdNum);
                    break;
                default:
                    for (int i = 0; i < count-3; i++)
                    {
                        sum = firstNum + secondNum + thirdNum;
                
                        firstNum = secondNum;
                        secondNum = thirdNum;
                        thirdNum = sum;
                    }
                    Console.WriteLine(sum);
                    break;
            }
            
        }
    }
}
