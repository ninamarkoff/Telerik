using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

/* Problem 4, Lecture 8:
 * Write a program that finds how many times a substring is contained in a given text
 * (perform case insensitive search).
 * Example: The target substring is "in". The text is as follows:
 * 
 * We are living in an yellow submarine. We don't have anything else. 
 * Inside the submarine is very tight. So we are drinking all the day. 
 * We will move out of it in 5 days.
 * 
 * The result is: 9. */


class CountOfSubstring
{
    static void Main()
    {
        string someString = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days. We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days. We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string subString = "in";

        Console.WriteLine("The count of '{0}' in the given string:\n{1} is:\n{2}", subString, someString,  Regex.Matches(someString, subString, RegexOptions.IgnoreCase).Count);
    }
}