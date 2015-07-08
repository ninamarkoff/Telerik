using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 7, Lecture 4:
 * Write a program to convert from any numeral system of given
 * base s to any other numeral system of base d (2 ≤ s, d ≤  16). */

class FromOneBaseToAnother
{
    public static string BaseAToBaseB(string number, int initBase, int otherBase)
    {
        string result = "";
        ulong base10number = 0;
        if (number == "0")
        {
            result = "0";
        }
        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (number[i] >= '0' && number[i] <= '9')
            {
                base10number += (ulong)(number[i]-'0') * (ulong)Math.Pow(initBase, number.Length - i - 1);
            }
            else if (number[i] >= 'A' && number[i] <= 'Z')
            {
                base10number += (ulong)(number[i] - 'A' + 10) * (ulong)Math.Pow(initBase, number.Length - i - 1);
            }
            else if (number[i] >= 'a' && number[i] <= 'z')
            {
                base10number += (ulong)((int)number[i] - 'a' + 10) * (ulong)Math.Pow(initBase, number.Length - i - 1);   
            }
        }
        while (base10number > 0)
        {
            if (base10number % (ulong)otherBase > 9)
            {
                switch (base10number % (ulong)otherBase)
                {
                    case 10: result += "A"; break;
                    case 11: result += "B"; break;
                    case 12: result += "C"; break;
                    case 13: result += "D"; break;
                    case 14: result += "E"; break;
                    case 15: result += "F"; break;

                    default: break;
                }
                base10number /= (ulong)otherBase;
            }
            else
            {
                result += Convert.ToString(base10number % (ulong)otherBase);
                base10number /= (ulong)otherBase;
            }
        }
        string resultReversed = new string(result.Reverse().ToArray());
        return resultReversed;
    }

    static void Main()
    {
        Console.WriteLine("Please enter the number you want to convert, its initial base and the new base you want to convert to: ");
        string valNumber = Console.ReadLine();
        int initialBase = int.Parse(Console.ReadLine());
        int othBase = int.Parse(Console.ReadLine());
        Console.WriteLine("The representation of {0}({1}) is: {2}({3})", valNumber, initialBase, BaseAToBaseB(valNumber, initialBase, othBase), othBase );
    }
}

