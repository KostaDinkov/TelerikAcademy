using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Sand_glass
{
    class SandGlass
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int middle = (height / 2) + 1;
            int starts = height;
            for (int i = 0; i < middle; i++)
            {
                Console.Write(new string('.',i));
                Console.Write(new string('*',starts));
                Console.Write(new string('.', i));
                Console.WriteLine();
                starts -= 2;
            }
            starts = 3;
            for (int i = middle -2; i >=0; i--)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('*', starts));
                Console.Write(new string('.', i));
                Console.WriteLine();
                starts += 2;

            }
        }
    }
}
