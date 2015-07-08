using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Problem 6, Lecture 8:
 * Write a program that reads from the console a string of maximum 20 characters.
 * If the length of the string is less than 20, the rest of the characters should 
 * be filled with '*'. Print the result string into the console. */

class StringOf20Chars
{
    static void Main()
    {
        StringBuilder str = new StringBuilder();
        Console.WriteLine("Please enter some string, no longer than 20 characters:");
        str.Append(Console.ReadLine());
        if (str.Length < 20)
        {
            for (int i = str.Length; i < 20; i++)
            {
                str.Append('*');
            }
        }
        Console.WriteLine("The string after the modification is: {0}", str);
    }
}