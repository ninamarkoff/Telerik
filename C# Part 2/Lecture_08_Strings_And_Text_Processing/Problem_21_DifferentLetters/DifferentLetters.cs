using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Problem 21, Lecture 8:
 * Write a program that reads a string from the console and prints all different
 * letters in the string along with information how many times each letter is found. */

class DifferentLetters
{
    static void Main()
    {
        string inputString = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";

        int[] values = new int[26];

        foreach (char ch in inputString.ToLower())
        {
            if ('a' <= ch && ch <= 'z') values[ch - 'a']++;
        }

        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] != 0)
            {
                Console.WriteLine("{0}: {1}", (char)(i + 'a'), values[i]);
            }
        }
    }
}