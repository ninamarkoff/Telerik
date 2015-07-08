using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 6, Lecture 4:
 * Write a program to convert binary numbers to hexadecimal numbers (directly). */

class BinaryToHexadecimal
{
    public static string BinToHex(string number)
    {
        string result = "";
        string hexPart = "";
        if (number == "0")
        {
            result = "0";
        }
        if (number.Length % 4 != 0)
        {
            switch (number.Substring(0, number.Length % 4))
            {
                case "1": hexPart = "1"; break;
                case "10": hexPart = "2"; break;
                case "11": hexPart = "3"; break;
                case "100": hexPart = "4"; break;
                case "101": hexPart = "5"; break;
                case "110": hexPart = "6"; break;
                case "111": hexPart = "7"; break;
            }
            result += hexPart;
        }
        for (int i = number.Length % 4; i < number.Length; i += 4)
        {
            switch (number.Substring(i, 4))
            {
                case "0001": hexPart = "1"; break;
                case "0010": hexPart = "2"; break;
                case "0011": hexPart = "3"; break;
                case "0100": hexPart = "4"; break;
                case "0101": hexPart = "5"; break;
                case "0110": hexPart = "6"; break;
                case "0111": hexPart = "7"; break;
                case "1000": hexPart = "8"; break;
                case "1001": hexPart = "9"; break;
                case "1010": hexPart = "A"; break;
                case "1011": hexPart = "B"; break;
                case "1100": hexPart = "C"; break;
                case "1101": hexPart = "D"; break;
                case "1110": hexPart = "E"; break;
                case "1111": hexPart = "F"; break;
            }
            result += hexPart;
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Please enter binary number to represent it as hexadecimal: ");
        string valN = Console.ReadLine();
        Console.WriteLine("The hexadecimal representation of {0} is: {1}", valN, BinToHex(valN));
    }
}

