using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0x100;
            Console.WriteLine(number);
            char symbol = '\u0048';
            Console.WriteLine(symbol);
            string a = "Hello";
            string b = "World";
            object c = a + " " + b;
            Console.WriteLine(c);
            string d = (string)c;
            Console.WriteLine(d);
        }
    }
}
