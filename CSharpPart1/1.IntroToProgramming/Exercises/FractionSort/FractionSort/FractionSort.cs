using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionSort
{
    class FractionSort
    {
        static void Main()
        {
            while (true)
            {
                Dictionary<string, decimal> dict = new Dictionary<string, decimal>();
                            
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter Fraction:");
                    string input = Console.ReadLine();
                    string[] frac = input.Split('/');

                    decimal numerator = Convert.ToDecimal(frac[0]);
                    decimal denumerator = Convert.ToDecimal(frac[1]);
                
                    dict.Add(frac[0] + "/" + frac[1], numerator / denumerator);
                }
                var sortedDict = (from entry in dict orderby entry.Value ascending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);
                Console.WriteLine("Answer:\n");
                foreach (var pair in sortedDict)
                {
                    Console.WriteLine("{0}= {1}",pair.Key,pair.Value);
                }
            }
        }
    }
}
