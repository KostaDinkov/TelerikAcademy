using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Astrological_Digits
{
    class AstrologicalDigits
    {
        static void Main(string[] args)
        {
            long sum = long.MaxValue;
            string input = Console.ReadLine();
            while (sum>9)
            {
                sum = 0;
                char[] digits = input.ToCharArray();
                foreach (var digit in digits)
                {
                    byte currentDigit = 0;
                    if (byte.TryParse(digit.ToString(), out currentDigit))
                    {
                        sum = sum + currentDigit;
                    }

                }
                input = sum.ToString();
            }
            Console.WriteLine(sum);
        }
    }
}
