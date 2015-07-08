using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/* Problem 22, Lecture 8:
 * Write a program that reads a string from the console and lists all different 
 * words in the string along with information how many times each word is found. */

class DifferentWords
{
    static void Main()
    {
        string inputString = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";

        var dictionary = new Dictionary<string, int>();

        foreach (Match word in Regex.Matches(inputString, @"\w+"))
        {
            dictionary[word.Value] = dictionary.ContainsKey(word.Value) ? dictionary[word.Value] + 1 : 1;
        }

        foreach (var pair in dictionary)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}