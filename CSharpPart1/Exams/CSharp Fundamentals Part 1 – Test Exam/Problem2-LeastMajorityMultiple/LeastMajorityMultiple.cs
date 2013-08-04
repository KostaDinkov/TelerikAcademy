using System;
using System.Linq;
using System.Collections.Generic;

class LeastMajorityMultiple
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int counter = 0;
        List<int> numbers = new List<int>();
        numbers.Add(a);
        numbers.Add(b);
        numbers.Add(c);
        numbers.Add(d);
        numbers.Add(e);
        numbers.Sort();
        

        for (int tmp = 0; ; tmp++)
        {
            foreach (var number in numbers)
            {
                if (tmp%number ==0 && tmp >=number)
                {
                    counter++;
                }
                if (counter == 3)
                {
                    Console.WriteLine(tmp);
                    return;
                }
            }
            counter = 0;
        }
    }
}

