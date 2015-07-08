using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/* Problem 14, Lecture 8:
 * A dictionary is stored as a sequence of text lines containing words and their explanations.
 * Write a program that enters a word and translates it by using the dictionary.
 * Sample dictionary:
 * 
 * .NET – platform for applications from Microsoft
 * CLR – managed execution environment for .NET
 * namespace – hierarchical organization of classes
 * 
 * */


class DictionaryTranslation
{
    static void Main()
    {
        string[] dictionary = 
        {
            ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical - organization of classes",
            "Dog - an animal",
            "Cat - some other animal", 
            "Female developer - Processing...Please wait...Sorry, no such thing!"
        };
        Console.Write("Please enter a word do be explained: ");
        string word = Console.ReadLine();

        foreach (string item in dictionary)
        {
            var parts = Regex.Match(item, "(.*?) - (.*)").Groups;

            if (parts[1].Value == word)
            {
                Console.WriteLine("{0} - {1}", word, parts[2]);
                return;
            }
            else if (item==dictionary[dictionary.Length-1])
            {
                Console.WriteLine("The word does not exist in the dictionary!");
                break;
            }
        }
    }
}
