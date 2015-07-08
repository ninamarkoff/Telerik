using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 5, Lecture 5:
 * Write a method that calculates the number of workdays between today and given date,
 * passed as parameter. Consider that workdays are all days from Monday to Friday
 * except a fixed list of public holidays specified preliminary as array. */

class Workdays
{
    public static int WorkingDays(DateTime someday)
    {
        DateTime[] Holidays = { new DateTime(2013, 01, 01), new DateTime(2013, 03, 03), new DateTime(2013, 05, 01), new DateTime(2013, 05, 02), new DateTime(2013, 05, 03), new DateTime(2013, 05, 04), new DateTime(2013, 05, 05), new DateTime(2013, 05, 06), new DateTime(2013, 05, 24), new DateTime(2013, 09, 06), new DateTime(2013, 09, 22), new DateTime(2013, 11, 01), new DateTime(2013, 12, 24), new DateTime(2013, 12, 25), new DateTime(2013, 12, 26), new DateTime(2013, 12, 31) };
        DayOfWeek[] WorkDays = { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday };
        int period = 0;
        for (DateTime i = DateTime.Today.Date; i <= someday.Date; i=i.AddDays(1))
        {
            if (!Holidays.Contains(i) && WorkDays.Contains(i.DayOfWeek))
            {
                period++;
            }
        }
        return period;
    }
    static void Main()
    {
        Console.Write("Please enter day of the year: ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Please enter month of the year: ");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("The working days from {0} to {1} are: {2}", DateTime.Today, new DateTime(2013, month, day), WorkingDays(new DateTime(2013, month, day)));
    }
}

