using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 3, Lecture 4:
 * Write a program to convert decimal numbers to their hexadecimal representation. */

class DecimalToHexadecimal
{
    public static string DecToHex(ulong number)
    {
        List<string> numberHexReversed = new List<string>();
        ulong numberCopy = number;
        string result = "";
        if (number == 0)
        {
            result = "0";
        }
        while (numberCopy > 0)
        {
            if (numberCopy % 16 < 10)
            {
                numberHexReversed.Add(Convert.ToString(numberCopy % 16));
                numberCopy /= 16;
            }
            else
            {
                switch (numberCopy % 16)
                {
                    case 10: numberHexReversed.Add("A"); break;
                    case 11: numberHexReversed.Add("B"); break;
                    case 12: numberHexReversed.Add("C"); break;
                    case 13: numberHexReversed.Add("D"); break;
                    case 14: numberHexReversed.Add("E"); break;
                    case 15: numberHexReversed.Add("F"); break;

                    default:
                        break;
                }
                numberCopy /= 16;
            }
        }
        for (int i = numberHexReversed.Count - 1; i >= 0; i--)
        {
            result += numberHexReversed[i];
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Please enter number to get it's hexadecimal representation: ");
        ulong valN = ulong.Parse(Console.ReadLine());
        Console.WriteLine("The hexadecimal representation of {0} is: {1}", valN, DecToHex(valN));
    }
}

