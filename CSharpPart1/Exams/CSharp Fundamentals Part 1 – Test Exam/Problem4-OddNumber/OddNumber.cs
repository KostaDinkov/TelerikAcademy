using System;
using System.Collections.Generic;

class OddNumber
{
    static void Main()
    {
        int numberCount = int.Parse(Console.ReadLine());
        List<long> numbers = new List<long>();
        Dictionary<long, long> dict = new Dictionary<long, long>();
        for (int i = 0; i < numberCount; i++)
        {
            numbers.Add(long.Parse(Console.ReadLine()));
        }
        foreach (var number in numbers)
        {
            if (dict.ContainsKey(number))
            {
                dict[number] += 1;
            }
            else
            {
                dict.Add(number, 1);
            }
        }
        foreach (var item in dict)
        {
            if (item.Value%2!=0)
            {
                Console.WriteLine(item.Key);
            }
        }

        

    }
}

