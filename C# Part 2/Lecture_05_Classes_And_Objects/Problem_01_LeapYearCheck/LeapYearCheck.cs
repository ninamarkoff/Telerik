using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 1, Lecture 5:
 * Write a program that reads a year from the console and checks whether it is a leap.
 * Use DateTime. */

class LeapYearCheck
{
    static void Main()
    {
        Console.Write("Please enter a year to define wheter it is leap: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("The year {0} is leap: {1}", year, DateTime.IsLeapYear(year));
        Console.WriteLine();
    }
}

