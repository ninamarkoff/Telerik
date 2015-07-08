using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/* Problem 9, Lecture 8:
 * We are given a string containing a list of forbidden words and a text containing
 * some of these words. Write a program that replaces the forbidden words with asterisks. Example:
 * 
 * Microsoft announced its next generation PHP compiler today. It is based
 * on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
 * 
 * Words: "PHP, CLR, Microsoft"
 * The expected result:
 * 
 * ********* announced its next generation *** compiler today. It is based
 * on .NET Framework 4.0 and is implemented as a dynamic language in ***. */


class ReplaceForbiddenWords
{
    static void Main()
    {
        string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string forbiddenWords= "PHP, CLR, Microsoft";
        Console.WriteLine(Regex.Replace(input, forbiddenWords.Replace(", ", "|"), p => new String('*', p.Length)));
    }
}
