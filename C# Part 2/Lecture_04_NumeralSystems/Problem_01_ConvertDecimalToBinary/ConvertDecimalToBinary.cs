using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 1, Lecture 4:
     * Write a program to convert decimal numbers to their binary representation. */

class ConvertDecimalToBinary
{
    public static string ConvertToBin(int number)
    {
        string result = "";
        List<int> numberBinReversed = new List<int>();
        int numberCopy = number;
        if (number == 0)
        {
            result = "0";
        }
        while (numberCopy > 0)
        {
            numberBinReversed.Add(numberCopy % 2);
            numberCopy /= 2;
        }
        for (int i = numberBinReversed.Count - 1; i >= 0; i--)
        {
            result += Convert.ToString(numberBinReversed[i]);
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Please enter number to get it's binary representation: ");
        int valN = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of {0} is: {1}", valN, ConvertToBin(valN));
    }
}

