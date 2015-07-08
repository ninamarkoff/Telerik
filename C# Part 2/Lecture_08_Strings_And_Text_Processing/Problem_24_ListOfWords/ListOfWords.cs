using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/* Problem 24, Lecture 8:
* Write a program that reads a list of words, separated by spaces and prints the
* list in an alphabetical order. */

class ListOfWords
{
    static void Main()
    {
        string str = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";
        var words = new List<string>();
        foreach (Match word in Regex.Matches(str, @"\w+"))
        {
            words.Add(word.Value);
        }
        words.Sort();
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}