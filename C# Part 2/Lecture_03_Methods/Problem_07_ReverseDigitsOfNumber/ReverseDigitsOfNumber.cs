using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 7, Lecture 3:
 * Write a method that reverses the digits of given decimal number. Example: 256 -> 652 */


class ReverseDigitsOfNumber
{
    public static ulong ReverseDigits(ulong number)
    {
        string numberAsString = Convert.ToString(number);
        char[] numberAsCharArray = numberAsString.ToCharArray();
        char[] reversedNumberAsCharArray = numberAsCharArray.Reverse().ToArray();
        string numberReversedAsString = "";
        foreach (var item in reversedNumberAsCharArray)
        {
            numberReversedAsString += item;
        }
        return Convert.ToUInt64(numberReversedAsString);
    }
    static void Main()
    {
        Console.Write("Please enter number: ");
        ulong valN = ulong.Parse(Console.ReadLine());
        Console.WriteLine("The number reversed is: {0}", ReverseDigits(valN));
    }
}

