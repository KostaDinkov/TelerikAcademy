/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 3: Methods
 * Problem 1: Write a method that asks the user for his name and prints 
 *              “Hello, <name>” (for example, “Hello, Peter!”). 
 *              Write a program to test this method.
 */

using System;

namespace Problem01.Hello
{
    class Hello
    {
        static void Main()
        {
            SayHello();   
        }
        static void SayHello()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello, {0} !",name);
        }
    }
    

}
