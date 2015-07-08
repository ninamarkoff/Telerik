using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Problem 10, Lecture 8:
* Write a program that converts a string to a sequence of C# Unicode character literals.
* Use format strings. Sample input:
* 
* Hi!
* 
* Expected output:
* 
* \u0048\u0069\u0021  */

class ConvertToUnicode
{
    static void Main()
    {
        Console.WriteLine("Please enter some string: ");
        StringBuilder input = new StringBuilder();
        input.Append(Console.ReadLine());
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            output.AppendFormat("\\u{0:X4}", (int)(input[i]));
        }
        Console.WriteLine(output);
    }
}
