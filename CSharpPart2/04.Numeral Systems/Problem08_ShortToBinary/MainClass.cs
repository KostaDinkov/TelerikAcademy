/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 4: Numeral Systems
 * Problem 8: Write a program that shows the binary 
 *              representation of given 16-bit signed integer number (the C# type short).
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Problem08_ShortToBinary
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a integer between -32 768 to  32 767  : ");
            short input = short.Parse(Console.ReadLine());
            List<int> bits = new List<int>();

            if (input>=0)
            {
                string result = DecimalToBin(input);
                Console.WriteLine(result);
            }
            else
            {
                //adding the next 2 lines to compare my result to a correct one
                string result = Convert.ToString(input, 2);
                Console.WriteLine("Result from Covert.ToString() : {0} ",result);
                
                StringBuilder binaryNum = new StringBuilder();
                input = (short)(Math.Abs(input)-1);
                while (input != 0)
                {
                    bits.Add(input % 2);
                    input /= 2;
                }
                
                bits.Reverse();

                for (int i = 0; i < bits.Count; i++)
                {
                    if (bits[i] == 0)
                    {
                        binaryNum.Append("1");
                    }
                    else
                    {
                        binaryNum.Append("0");
                    }
                }
                while (binaryNum.Length % 16 != 0)
                {
                    binaryNum.Insert(0, "1");
                }
                Console.WriteLine();
                Console.WriteLine("My Result :                     {0}",binaryNum);

                

            }

            

            
        }
        static string DecimalToBin(int iDec)
        {

            string strBin = "";
            int[] result = new int[32];
            int maxBit = 32;
            for (; iDec > 0; iDec /= 2)
            {
                int rem = iDec % 2;
                result[--maxBit] = rem;
            }
            for (int i = 0; i < result.Length; i++)
                
            strBin += result.GetValue(i);
            strBin = strBin.TrimStart(new char[] { '0' });
            return strBin;
        }
    }
     
}
