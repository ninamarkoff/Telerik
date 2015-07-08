using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

/* Problem 16, Lecture 8:
* Write a program that reads two dates in the format: day.month.year and
* calculates the number of days between them. Example:
* 
* Enter the first date: 27.02.2006
* Enter the second date: 3.03.2004
* Distance: 4 days
* */

class ReadTwoDates
{
    static void Main()
    {
        Console.WriteLine("Please enter two dates in format day.month.year: ");
        Console.Write("First date: ");
        string firstDate = Console.ReadLine();
        Console.Write("Second date: ");
        string secondDate = Console.ReadLine();
        DateTime start = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime end = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Distance: {0} days", (end - start).TotalDays);
    }
}
