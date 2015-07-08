using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 5, Lecture 4:
 * Write a program to convert hexadecimal numbers to binary numbers (directly). */

class HexadecimalToBinary
{
    public static string HexToBin(string number)
    {
        string result = "";
        if (number == "0")
        {
            result = "0";
        }
        for (int i = 0; i < number.Length; i++)
        {
            if (i == 0)
            {
                switch (number[i])
                {
                    case '1': result += "1"; break;
                    case '2': result += "10"; break;
                    case '3': result += "11"; break;
                    case '4': result += "100"; break;
                    case '5': result += "101"; break;
                    case '6': result += "110"; break;
                    case '7': result += "111"; break;
                    case '8': result += "1000"; break;
                    case '9': result += "1001"; break;
                    case 'a':
                    case 'A': result += "1010"; break;
                    case 'b':
                    case 'B': result += "1011"; break;
                    case 'c':
                    case 'C': result += "1100"; break;
                    case 'd':
                    case 'D': result += "1101"; break;
                    case 'e':
                    case 'E': result += "1110"; break;
                    case 'f':
                    case 'F': result += "1111"; break;
                    default:
                        break;
                }
            }
            else
            {
                switch (number[i])
                {
                    case '1': result += "0001"; break;
                    case '2': result += "0010"; break;
                    case '3': result += "0011"; break;
                    case '4': result += "0100"; break;
                    case '5': result += "0101"; break;
                    case '6': result += "0110"; break;
                    case '7': result += "0111"; break;
                    case '8': result += "1000"; break;
                    case '9': result += "1001"; break;
                    case 'a':
                    case 'A': result += "1010"; break;
                    case 'b':
                    case 'B': result += "1011"; break;
                    case 'c':
                    case 'C': result += "1100"; break;
                    case 'd':
                    case 'D': result += "1101"; break;
                    case 'e':
                    case 'E': result += "1110"; break;
                    case 'f':
                    case 'F': result += "1111"; break;
                    default:
                        break;
                }
            }

        }
        return result;
    }
    static void Main()
    {
        Console.Write("Please enter hexadecimal number to represent it as binary: ");
        string valN = Console.ReadLine();
        Console.WriteLine("The binary representation of {0} is: {1}", valN, HexToBin(valN));
    }
}

