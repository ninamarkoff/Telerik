using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 2, Lecture 4:
 * Write a program to convert binary numbers to their decimal representation. */

class BinaryToDecimal
{
    public static ulong BinToDec(ulong number)
    {
        ulong numberCopy = number;
        ulong result = 0;
        int counter = 0;
        while (numberCopy > 0)
        {
            result += ((numberCopy % 10) * (ulong)Math.Pow(2, counter));
            counter++;
            numberCopy /= 10;
        }
        return result;

    }
    static void Main()
    {
        Console.Write("Please enter binary number to represent it as decimal: ");
        ulong valN = ulong.Parse(Console.ReadLine());
        Console.WriteLine("The decimal representation of {0} is: {1}", valN, BinToDec(valN));
    }
}

