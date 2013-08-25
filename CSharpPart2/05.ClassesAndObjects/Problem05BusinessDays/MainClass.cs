/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 5: Objects and Classes
 * Problem 5: Write a method that calculates the number 
 *              of workdays between today and given date, 
 *              passed as parameter. Consider that workdays are 
 *              all days from Monday to Friday except a fixed 
 *              list of public holidays specified preliminary 
 *              as array.
 */

using System;

namespace Problem05BusinessDays
{
    class MainClass
    {
        // a list of the official Bulgarian holidays
        static  DateTime[] holidays = new DateTime[]
        {
            new DateTime(2013,1,1),
            new DateTime(2013,3,3),
            new DateTime(2013,6,1),
            new DateTime(2013,6,6),
            new DateTime(2013,6,24),
            new DateTime(2013,9,6),
            new DateTime(2013,9,22),
            new DateTime(2013,11,1),
            new DateTime(2013,12,24),
            new DateTime(2013,12,25),
            new DateTime(2013,12,26)
        };

        static void Main()
        {
            Console.WriteLine("Enter the last date for the period for which you wish to calculate the business days: (YYYY,MM,DD)");
            DateTime lastDate = DateTime.Parse(Console.ReadLine());
            int businesDaysCount = BusinessDaysUntil(lastDate);

            Console.WriteLine("the number of business days from {0} to {1} are: {2}",DateTime.Now,lastDate,businesDaysCount);

        }
        
        public static int BusinessDaysUntil(DateTime lastDay)
        {
            DateTime firstDay = DateTime.Now;
            lastDay = lastDay.Date;
            if (firstDay > lastDay)
                throw new ArgumentException("The last day must be AFTER today -  " + lastDay);

            TimeSpan span = lastDay - firstDay;
            int businessDays = span.Days + 1;
            int fullWeekCount = businessDays / 7;
            // find out if there are weekends during the time exceeding the full weeks
            if (businessDays > fullWeekCount * 7)
            {
                // we are here to find out if there is a 1-day or 2-days weekend
                // in the time interval remaining after subtracting the complete weeks
                int firstDayOfWeek = firstDay.DayOfWeek == DayOfWeek.Sunday ? 7 : (int)firstDay.DayOfWeek;
                int lastDayOfWeek = lastDay.DayOfWeek == DayOfWeek.Sunday ? 7 : (int)lastDay.DayOfWeek;
                if (lastDayOfWeek < firstDayOfWeek)
                    lastDayOfWeek += 7;
                if (firstDayOfWeek <= 6)
                {
                    if (lastDayOfWeek >= 7)// Both Saturday and Sunday are in the remaining time interval
                        businessDays -= 2;
                    else if (lastDayOfWeek >= 6)// Only Saturday is in the remaining time interval
                        businessDays -= 1;
                }
                else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)// Only Sunday is in the remaining time interval
                    businessDays -= 1;
            }

            // subtract the weekends during the full weeks in the interval
            businessDays -= fullWeekCount + fullWeekCount;

            // subtract the number of official holidays during the time interval
            foreach (DateTime holiday in holidays)
            {
                DateTime h = holiday.Date;
                if (firstDay <= h && h <= lastDay)
                    --businessDays;
            }

            return businessDays;
        }
    }
}
