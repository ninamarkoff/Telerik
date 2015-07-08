﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/* Problem 8, Lecture 8:
 * Write a program that extracts from a given text all sentences containing given word.
 * Example: The word is "in". The text is:
 * 
 * We are living in a yellow submarine. We don't have anything else. 
 * Inside the submarine is very tight. So we are drinking all the day. 
 * We will move out of it in 5 days.
 * 
 * The expected result is:
 * 
 * We are living in a yellow submarine.
 * We will move out of it in 5 days.
 * 
 * Consider that the sentences are separated by "." and the words – by non-letter symbols. */


class ExtractSentences
{
    static void Main()
    {
        string input = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days. We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days. We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string keyword = "in";
        foreach (Match sentence in Regex.Matches(input, @"\s*([^\.]*\b" + keyword + @"\b.*?\.)"))
            Console.WriteLine(sentence.Groups[1]);
    }
}
