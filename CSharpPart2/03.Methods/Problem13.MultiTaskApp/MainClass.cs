/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 3: Methods
 * Problem 13: Write a program that can solve these tasks:
 *              Reverses the digits of a number
 *              Calculates the average of a sequence of integers
 *              Solves a linear equation a * x + b = 0
 *		                Create appropriate methods.
 *		                Provide a simple text-based menu for the user to choose which task to solve.
 *		                Validate the input data:
 *              The decimal number should be non-negative
 *              The sequence should not be empty
 *              a should not be equal to 0
 */


using System;
using System.Text;

class MainClass
{
    static void Main()
    {
        Console.WriteLine("1.For reversing digits of a number press \"1\" and Enter:");
        Console.WriteLine("2.For calculating the average of a sequence of integers press \"2\" and Enter:");
        Console.WriteLine("3.For solving a linear equation press \"3\" and Enter:");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine();
        switch (input)
        {
            case 1:
                ReverseDig();
                break;
            case 2:
                CalcAvg();
                break;
            case 3:
                SolveLequation();
                break;
            default:
                Console.WriteLine("Wrong choice! Try again! Choose from \"1\", \"2\" or \"3\" ");
                break;
        }
    }

    private static void SolveLequation()
    {
        decimal a = 0m;
        do
        {
            Console.WriteLine("Enter \"a\" and \"b\" of the equation a*x+b=0 (a!=0) separated by Enters:");
            a = decimal.Parse(Console.ReadLine());
        } while (a == 0m);
        decimal b = decimal.Parse(Console.ReadLine());
        Console.WriteLine();
        decimal x = (-b) / a;
        Console.WriteLine("x = " + x);
    }
    private static void CalcAvg()
    {
        //aL - specify array's length
        int aL = 0;
        do
        {
            Console.WriteLine("Specify the length of the sequence:");
            aL = int.Parse(Console.ReadLine());
        } while (aL < 1);

        int sum = 0;
        int[] arr = new int[aL];

        Console.WriteLine("Enter the {0} integers separated by Enters:", aL);

        for (int i = 0; i < aL; i++)
        {
            bool check = false;

            do
            {
                Console.Write("{0}. - ", i + 1);
                string temp = Console.ReadLine();
                bool trp = int.TryParse(temp, out arr[i]);
                if (trp == true)
                {
                    check = true;
                }
            } while (check == false);
            sum += arr[i];
            Console.WriteLine();
        }
        Console.WriteLine("Average = " + sum / aL);
    }
    private static void ReverseDig()
    {

        decimal n = 0;
        do
        {
            Console.WriteLine("Enter a positive number (654.321)");
            n = decimal.Parse(Console.ReadLine());
        } while (n < 1);
        string number = n.ToString();
        StringBuilder sb = new StringBuilder();

        for (int i = number.Length - 1; i >= 0; i--)
        {
            sb.Append(number[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Reversed = " + sb.ToString());
    }
}