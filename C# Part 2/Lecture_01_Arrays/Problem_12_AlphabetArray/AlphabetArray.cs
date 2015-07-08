using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 12, Lecture 1:
 * Write a program that creates an array containing all letters from the alphabet (A-Z).
 * Read a word from the console and print the index of each of its letters in the array. */


class AlphabetArray
{
    static void Main()
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        Console.Write("Please write down a word in lower case: ");
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i]==alphabet[j])
                {
                    Console.Write("{0} ", j);
                }
            }
        }
        Console.WriteLine();
    }
}

