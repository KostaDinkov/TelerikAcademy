using System;
using System.Numerics;
using System.Collections.Generic;


class SubsetSums
{
    static void Main()
    {
        
        int counter = 0;
        BigInteger S = BigInteger.Parse(Console.ReadLine());
        int numCount = int.Parse(Console.ReadLine());
        BigInteger[] numSet = new BigInteger[numCount];
        for (int i = 0; i < numCount; i++)
        {
            numSet[i] = BigInteger.Parse(Console.ReadLine());

        }
        List<string> combinations = new List<string>();
        for (int i = 1; i <= (Math.Pow(2,numCount)-1); i++)
        {
            combinations.Add(Convert.ToString(i, 2).PadLeft(numCount,'0'));
        }
        
        foreach (var combination in combinations)
        {
            List<BigInteger> subset = new List<BigInteger>();
            BigInteger currentSum = 0;
            for (int i = numCount - 1; i >= 0; i--)
            {
                if (combination[i] == '1')
                {
                    subset.Add(numSet[i]);
                }
            }
            foreach (var number in subset)
            {
                currentSum += number;
            }
            if (currentSum == S)
            {
                counter++;
            }


        }

        Console.WriteLine(counter);

    }
}

