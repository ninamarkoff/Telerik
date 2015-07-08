using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/* Problem 13, Lecture 8:
 * Write a program that reverses the words in given sentence.
 * Example: "C# is not C++, not PHP and not Delphi!" ->
 * "Delphi not and PHP, not C++ not is C#!". */

class ReverseSentence
{
    static void Main()
    {

        string input = "C#   is not C++, not PHP and not Delphi!";

        string regularExpression = @"\s+|,\s*|\.\s*|!\s*|$";

        var words = new Stack<string>();

        foreach (var word in Regex.Split(input, regularExpression))
        {
            if (!String.IsNullOrEmpty(word))
            {
                words.Push(word);
            }
        }

        foreach (var separator in Regex.Matches(input, regularExpression))
        {
            if (words.Count != 0)
            {
                Console.Write(words.Pop() + separator);
            }
            else
            {
                break;
            }
        }
        Console.WriteLine();
    }
}