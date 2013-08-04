using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_FallDown
{
    class FallDown
    {
        static void Main()
        {
            int[] numbers = new int[8];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            char[][] bits = new char[8][];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                bits [i] = Convert.ToString(numbers[i],2).PadLeft(8,'0').ToCharArray();
            }
            
            bool moved = true;
            while (moved==true)
            {
                moved = false;
                for (int line = 7; line >= 0; line--)
                {
                    for (int position = 0; position < 8; position++)
                    {
                        if (bits[line][position] == '1' && line != 7 && bits[line + 1][position] == '0')
                        {
                            bits[line][position] = '0';
                            bits[line + 1][position] = '1';
                            moved = true;
                        }
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                string str = new string(bits[i]);
                int result = Convert.ToInt32(str, 2);
                Console.WriteLine(result);
            }
        }
    }
}
