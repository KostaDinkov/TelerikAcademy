using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirTree
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int star = 1;
        int point = height - 2;
        

        for (int i = 0; i < height - 1; i++)
        {
            Console.Write(new string('.',point));
            Console.Write(new string('*', star));
            Console.WriteLine(new string('.', point));
            point -= 1;
            star += 2;
        }
        Console.Write(new string('.',height-2));
        Console.Write(new string('*', 1));
        Console.WriteLine(new string('.', height - 2));
    }
}

