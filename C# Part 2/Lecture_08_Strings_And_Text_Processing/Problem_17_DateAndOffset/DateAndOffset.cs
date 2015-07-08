using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

/* Problem 17, Lecture 8:
 * Write a program that reads a date and time given in the format: 
 * day.month.year hour:minute:second and prints the date and time after 
 * 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian. */

namespace DateAndOffset
{
    class DateAndOffset
    {
        static void Main()
        {            
            Console.Write("Please enter date and time in fomat day.month.year hour:minute:second :");
            string dateAndTime = Console.ReadLine();
            //string dateAndTime = "06.05.1981 23:45:06";
            DateTime date = DateTime.ParseExact(dateAndTime, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            date = date.AddHours(6.5);
            Console.WriteLine("{0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
        }
    }
}