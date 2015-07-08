using System;
using System.Collections.Generic;

/* Probem 2, Lecture 8:
* Write a program that reads a string, reverses it and prints the result at the console. 
* Example: "sample" -> "elpmas". */

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Please enter some string: ");
        string someString = Console.ReadLine();
        char[] charArray = someString.ToCharArray();
        int length = someString.Length - 1;

        for (int i = 0; i < length; i++, length--)
        {
            charArray[i] ^= charArray[length];
            charArray[length] ^= charArray[i];
            charArray[i] ^= charArray[length];
        }
        Console.WriteLine("The reversed string is: {0}", new string(charArray));
    }
}