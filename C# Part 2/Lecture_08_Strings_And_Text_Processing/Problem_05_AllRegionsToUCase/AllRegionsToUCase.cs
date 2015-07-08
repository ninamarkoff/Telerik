using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

/* Problem 5, Lecture 8:
 * You are given a text. Write a program that changes the text in all regions surrounded
 * by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
 * 
 * We are living in a <upcase>yellow submarine</upcase>. 
 * We don't have <upcase>anything</upcase> else.
 * 
 * The expected result:
 * We are living in a YELLOW SUBMARINE. We don't have ANYTHING else. */


class AllRegionsToUCase
{
    static void Main()
    {
        string someString = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else. We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(Regex.Replace(someString, "<upcase>(.*?)</upcase>", p => p.Groups[1].Value.ToUpper()));
    }
}
