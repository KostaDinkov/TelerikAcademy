using System;
using Homework.Models;
using Homework.TestClasses;

namespace Homework
{
    class HomeworkMain
    {
        static void Main(string[] args)
        {
            // Problem 7
            Console.WriteLine("Testing Class GSM");
            foreach (GSM gsm in GsmTest.gsms)
            {
                Console.WriteLine(gsm.ToString());
            }

            Console.WriteLine("To see more test results, press any key...");
            Console.ReadKey();
            Console.Clear();


            // Problem 12
            Console.WriteLine("Testing Call History");
            CallHistoryTest.TestCallHistory();
        }
    }
}