using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Probem 7, Lecture 8:
 * Write a program that encodes and decodes a string using given encryption key (cipher).
 * The key consists of a sequence of characters. The encoding/decoding is done by
 * performing XOR (exclusive or) operation over the first letter of the string with
 * the first of the key, the second – with the second, etc. When the last key character
 * is reached, the next is the first. */

class EncodeAndDecodeText
{
    static void Main()
    {
        Console.WriteLine("Please enter some string: ");
        string someString = Console.ReadLine();
        StringBuilder output = new StringBuilder(someString.Length);
        StringBuilder key = new StringBuilder();
        Console.WriteLine("Please enter encryption key/cipher: ");
        key.Append(Console.ReadLine());       
            for (int i = 0; i < someString.Length; i++)
            {
                output.Append(Convert.ToChar((int)someString[i] ^ (int)key[i % key.Length]));
            }
        Console.WriteLine("The encrypted string is: {0}", output);
    }
}
