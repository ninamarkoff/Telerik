using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 3, Lecture 3:
 * Write a method that returns the last digit of given integer as an English word.
 * Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine". */

class LastDigitAsWord
{
    static string LastDigitOfNumber(int number)
    {
        string lastDigitString="";
        switch (number%10)
        {
            case 0: lastDigitString = "Zero"; break;
            case 1: lastDigitString = "One"; break;
            case 2: lastDigitString = "Two"; break;
            case 3: lastDigitString = "Three"; break;
            case 4: lastDigitString = "Four"; break;
            case 5: lastDigitString = "Five"; break;
            case 6: lastDigitString = "Six"; break;
            case 7: lastDigitString = "Seven"; break;
            case 8: lastDigitString = "Eight"; break;
            case 9: lastDigitString = "Nine"; break;
            default:
                break;
        }
        return lastDigitString;
    }
    static void Main()
    {
        Console.WriteLine("Please enter some integer:");
        int valN = int.Parse(Console.ReadLine());
        Console.WriteLine("The last digit of {0} is: {1}", valN, LastDigitOfNumber(valN));
    }
}

