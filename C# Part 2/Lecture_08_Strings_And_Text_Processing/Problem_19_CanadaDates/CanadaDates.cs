using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/* Problem 19, Lecture 8:
 * Write a program that extracts from a given text all dates that match the
 * format DD.MM.YYYY. Display them in the standard date format for Canada. */

class CanadaDates
{
    static void Main()
    {
        string input = "Static void Main() 03.09.2013, 06.05.2013";

        DateTime date;
        foreach (Match item in Regex.Matches(input, @"\b\d{2}.\d{2}.\d{4}\b"))
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
    }
}