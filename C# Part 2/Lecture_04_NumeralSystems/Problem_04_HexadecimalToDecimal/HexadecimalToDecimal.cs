using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 4, Lecture 4:
 * Write a program to convert hexadecimal numbers to their decimal representation. */

class HexadecimalToDecimal
{
    public static ulong HexToDec(string number)
    {
        ulong result = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (Convert.ToInt16(number[i]) < 58)
            {
                result += Convert.ToUInt64(number[i] - 48) * (ulong)Math.Pow(16, number.Length - i - 1);
            }
            else
            {
                switch (number[i])
                {
                    case 'A': result += (ulong)10 * (ulong)Math.Pow(16, number.Length - i - 1); break;
                    case 'a': result += (ulong)10 * (ulong)Math.Pow(16, number.Length - i - 1); break;
                    case 'B': result += (ulong)11 * (ulong)Math.Pow(16, number.Length - i - 1); break;
                    case 'b': result += (ulong)11 * (ulong)Math.Pow(16, number.Length - i - 1); break;
                    case 'C': result += (ulong)12 * (ulong)Math.Pow(16, number.Length - i - 1); break;
                    case 'c': result += (ulong)12 * (ulong)Math.Pow(16, number.Length - i - 1); break;
                    case 'D': result += (ulong)13 * (ulong)Math.Pow(16, number.Length - i - 1); break;
                    case 'd': result += (ulong)13 * (ulong)Math.Pow(16, number.Length - i - 1); break;
                    case 'E': result += (ulong)14 * (ulong)Math.Pow(16, number.Length - i - 1); break;
                    case 'e': result += (ulong)14 * (ulong)Math.Pow(16, number.Length - i - 1); break;
                    case 'F': result += (ulong)15 * (ulong)Math.Pow(16, number.Length - i - 1); break;
                    case 'f': result += (ulong)15 * (ulong)Math.Pow(16, number.Length - i - 1); break;

                    default:
                        break;
                }
            }
        }
        return result;

    }
    static void Main()
    {
        Console.Write("Please enter hexadecimal number to represent it as decimal: ");
        string valN = Console.ReadLine();
        Console.WriteLine("The decimal representation of {0} is: {1}", valN, HexToDec(valN));
    }
}

