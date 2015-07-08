using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Problem 11, Lecture 8:
 * Write a program that reads a number and prints it as a decimal number,
 * hexadecimal number, percentage and in scientific notation. Format the 
 * output aligned right in 15 symbols. */

class NumberInDiffNotation
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int number =int.Parse(Console.ReadLine());
        Console.WriteLine("{0,15:D}", number);
        Console.WriteLine("{0,15:X}", number);
        Console.WriteLine("{0,15:P}", number);
        Console.WriteLine("{0,15:E}", number);
    }
}