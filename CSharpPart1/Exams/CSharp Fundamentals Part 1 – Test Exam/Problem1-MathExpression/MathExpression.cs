using System;

    class MathExpression
    {
        static void Main()
        {
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());

            double result1 = ((N * N) + (1d / (M * P)) + 1337d);
            double result2 = (N - (128.523123123 * P));
            double result3 = Math.Sin((int)M % 180);
            double finalResult = (result1 / result2) + result3;
            Console.WriteLine("{0:F6}", finalResult);
        }
    }

