using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/* Problem 18, Lecture 8:
 * Write a program for extracting all email addresses from given text.
 * All substrings that match the format <identifier>@<host>…<domain>
 * should be recognized as emails. */

class ExtractEmails
{
    static void Main()
    {
        string input = "Some random words and phrases soni@abv.bg. other unuseful words, cheshma@gmail.com end";
        foreach (var item in Regex.Matches(input, @"\w+@\w+\.\w+"))
        Console.WriteLine(item);
    }
}