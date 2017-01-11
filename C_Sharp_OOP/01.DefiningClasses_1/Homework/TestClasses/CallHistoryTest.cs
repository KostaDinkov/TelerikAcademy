using System;
using System.Linq;
using Homework.Models;

namespace Homework.TestClasses
{
    public static class CallHistoryTest
    {
        private const decimal PricePerMinute = 0.37m;

        private static GSM gsm = new GSM("Galaxy Note II",
                                         "Samsung",
                                         299,
                                         null,
                                         new Battery("K21300", BatteryType.LiIon, 300, 15),
                                         new Display(5.5, 16000000));

        public static void TestCallHistory()
        {
            // Add a few calls
            gsm.AddCall(new Call {Date = DateTime.Now, DialedPhone = "+359889555444", Duration = 300});
            gsm.AddCall(new Call {Date = DateTime.Now, DialedPhone = "+35912345678", Duration = 125});
            gsm.AddCall(new Call {Date = DateTime.Now, DialedPhone = "+359666666", Duration = 567});
            gsm.AddCall(new Call {Date = DateTime.Now, DialedPhone = "+000000000", Duration = 58});

            // Display information about the calls
            PrintCallHistory();

            // Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            CalculatePrice();

            // Remove the longest call from the history and calculate the total price again.
            var longestCall = gsm.CallHistory.OrderByDescending(c => c.Duration).FirstOrDefault();
            Console.WriteLine($"\nRemoving longest call (ID = {longestCall.Id})\n");
            gsm.CallHistory.Remove(longestCall);

            PrintCallHistory();
            CalculatePrice();

            // Finally clear the call history and print it.
            Console.WriteLine("Clearing call history.");
            gsm.ClearHistory();
            PrintCallHistory();
        }

        private static void PrintCallHistory()
        {
            Console.WriteLine("Printing call history ...");
            Console.WriteLine(gsm.GetCallHistory());
        }

        private static void CalculatePrice()
        {
            Console.WriteLine();
            Console.WriteLine("Calculating total price for all calls...");
            Console.WriteLine($"Total calls price: {gsm.CallPrice(PricePerMinute)}");
        }
    }
}