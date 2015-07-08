using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/* Problem 20, Lecture 8:
 * Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe". */

class ExtractPalindromes
{
    static bool PalindromeCheck(string inputString)
    {
        for (int i = 0; i < inputString.Length / 2; i++)
            if (inputString[i] != inputString[inputString.Length - 1 - i])
                return false;

        return true;
    }

    static void Main()
    {
        string input = "some meaningless text here to show if this works properly ABBA, lamal, exe capac sisis.";

        foreach (Match item in Regex.Matches(input, @"\w+"))
        {
            if (PalindromeCheck(item.Value)) Console.WriteLine(item);
        }
    }
}