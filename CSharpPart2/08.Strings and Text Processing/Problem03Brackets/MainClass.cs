/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 3: Write a program to check if in a given expression the 
 *              brackets are put correctly.
 *              Example of correct expression: ((a+b)/5-d).
 *              Example of incorrect expression: )(a+b)).
 */

using System;
using System.Collections.Generic;


namespace Problem03Brackets
{
    class MainClass
    {
        static void Main()
        {
            //Enter your custom  test expressions in the TestCheckBrackets() method below, as described

            TestCheckBrackets(); 

            //OR uncomment the following code to input your expression from the console
            
            //Console.WriteLine();
            //string expression = GetStringInput("Enter your expression :");
            //Console.WriteLine("Your expression is : {0}", CheckBrackets(expression) ? "CORRECT" : "INCORRECT");
        }
        static string GetStringInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
        static bool CheckBrackets(string input, char leftBracket='(', char rightBracket =')')
        {
            Stack<char> stack = new Stack<char>();
            foreach (var ch in input)
            {
                if (ch==leftBracket)
                {
                    stack.Push(ch);
                }
                else if (ch==rightBracket )
                {
                    if (stack.Count > 0)
                    {
                        if (stack.Peek() == leftBracket)
                        {
                            stack.Pop();
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            return false;
            
        }
        static void TestCheckBrackets()
        {
            // add custom tests in the array below. Follow the pattern
            string[] expressions = new string[]
            {
                "(a+b)",                // correct
                "a+(b+c)",              // correct
                "(a+b)+(c+d)",          // correct
                "((a+b)+(c+d))",        // correct    
                "((a+b)+(c+d)",         // incorrect
                ")(a+b)+(c+d)(",        // incorrect
                "))a+b((+))c+d((",      // incorrect
                "()a+b)(c+d)(",         // incorrect
            };

            int textNum = 1;
            foreach (var expression in expressions)
            {
                Console.Write("Test #{0} - {1,-20}  : ",textNum, expression);
                Console.WriteLine(CheckBrackets(expression) ? "CORRECT" : "INCORRECT");
                textNum++;
            }
        }
    }   
}
