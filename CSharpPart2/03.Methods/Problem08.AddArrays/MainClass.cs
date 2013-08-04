/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 3: Methods
 * Problem 8: Write a method that adds two positive integer numbers 
 *              represented as arrays of digits (each array element arr[i] 
 *              contains a digit; the last digit is kept in arr[0]). 
 *              Each of the numbers that will be added could have up to 10 000 digits.
 */

using System;
using System.Collections.Generic;

class MainClass
{
    static void Main()
    {
        PrintNumber(Add(new byte[] { 0, 0, 1 }, new byte[] { 0 }));
        Console.WriteLine();

        PrintNumber(Add(new byte[] { 1 }, new byte[] { 1 }));
        Console.WriteLine();

        PrintNumber(Add(new byte[] { 0, 1 }, new byte[] { 1 }));
        Console.WriteLine();

        PrintNumber(Add(new byte[] { 1 }, new byte[] { 9 }));
        Console.WriteLine();

        PrintNumber(Add(new byte[] { 1 }, new byte[] { 9, 9 }));
        Console.WriteLine();

        PrintNumber(Add(new byte[] { 1 }, new byte[] { 9, 9, 9 }));
        Console.WriteLine();

        PrintNumber(Add(new byte[] { 1 }, new byte[] { 9, 9, 9, 8 }));
        Console.WriteLine();

        PrintNumber(Add(new byte[] { 1 }, new byte[] { 9, 9, 9, 8, 7, 6 }));
        Console.WriteLine();

        PrintNumber(Add(new byte[] { 2, 1 }, new byte[] { 8, 8, 9, 9, 9, 8, 1 }));
    }
    static void PrintNumber(byte[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--) Console.Write(arr[i]); 

        Console.WriteLine();
    }
    static byte[] Add(byte[] a, byte[] b)
    {
        if (a.Length > b.Length) return Add(b, a); 

        PrintNumber(a);
        PrintNumber(b);

        byte[] result = new byte[b.Length + 1]; 
        int i = 0, carry = 0;

        for (; i < a.Length; i++)
        {
            result[i] = (byte)(a[i] + b[i] + carry);

            carry = result[i] / 10;
            result[i] %= 10;
        }

        for (; i < b.Length && carry != 0; i++)
        {
            result[i] = (byte)(b[i] + carry);

            carry = result[i] / 10;
            result[i] %= 10;
        }

        for (; i < b.Length; i++)
        {
            result[i] = b[i];
        }
        
        if (carry != 0) result[i] = 1;
        else Array.Resize(ref result, result.Length - 1); 

        return result;
    }
    // a better variant ...
    static List<int> AddRefactored(byte[] a, byte[] b)
    {
        var result = new List<int>(Math.Max(a.Length, b.Length));

        int carry = 0;
        for (int i = 0; i < result.Count; i++)
        {
            int currentDigit = (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0) + carry;

            carry = currentDigit / 10;
            result.Add(currentDigit % 10);
        }
        if (carry == 1) result.Add(1);

        return result;
    }
}