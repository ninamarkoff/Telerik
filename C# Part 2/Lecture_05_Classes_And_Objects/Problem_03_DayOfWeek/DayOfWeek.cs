using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 3, Lecture 5:
 * Write a program that prints to the console which day of the week is today.
 * Use System.DateTime. */

class DayOfWeek
{
    static void Main()
    {
        Console.WriteLine("Today is: {0}", DateTime.Today.DayOfWeek);
    }
}

