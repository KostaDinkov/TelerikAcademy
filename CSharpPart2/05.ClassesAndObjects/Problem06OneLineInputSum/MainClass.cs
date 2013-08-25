/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 5: Objects and Classes
 * Problem 6: You are given a sequence of positive integer 
 *              values written into a string, separated by 
 *              spaces. Write a function that reads these 
 *              values from given string and calculates 
 *              their sum. Example:
 *      		string = "43 68 9 23 318"  result = 461
 */
using System;


namespace Problem06OneLineInputSum
{
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine(" Enter the numbers you wish to sum on a single line separated by spaces:");
            string input = Console.ReadLine();
            
            int sum = SumNumbers(input);
            Console.WriteLine("The sum of the numbers is : {0}:", sum);
        }

        private static int SumNumbers(string str)
        {
            string[] stringElements = str.Split(' ');
            int sum = 0;
            foreach (var element in stringElements)
            {
                sum += int.Parse(element);

            }
            return sum;
        }
    }
}
