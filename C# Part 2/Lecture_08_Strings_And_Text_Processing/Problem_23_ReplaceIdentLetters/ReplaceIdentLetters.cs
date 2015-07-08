using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/* Problem 23, Lecture 8:
* Write a program that reads a string from the console and replaces all series of
* consecutive identical letters with a single one. 
* Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa". */

class ReplaceIdentLetters
{
    static void Main()
    {
        string inputString = "ssssssaarrrrtttttabbbbbcdddeeeedssaakkkkkkkllllllllmmmmmwwwww";
        Console.WriteLine(Regex.Replace(inputString, @"(\w)\1+", "$1"));
    }
}