using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 8, Lecture 4:
 * Write a program that shows the binary representation of given
 * 16-bit signed integer number (the C# type short). */

class ShortToBin
{
    public static string ShortToBinary(short number)
    {
        string result = "";
        short[] resultArray = new short[16];
        short mask;
        if (number == 0)
        {
            result = "0";
        }
        else if (number > 0)
        {
            for (short i = 0; i < resultArray.Length; i++)
            {
                mask = (short)(1 << (resultArray.Length - i - 1));
                resultArray[i] = (short)((mask & number) >> (resultArray.Length - i - 1));
            }
            int counter = 0;
            while (resultArray[counter]==0)
            {
                counter++;
            }
            for (int i = counter; i < resultArray.Length; i++)
            {
                result += Convert.ToString(resultArray[i]);
            }
        }
        else
        {
            for (short i = 0; i < resultArray.Length; i++)
            {
                mask = (short)(1 << (resultArray.Length - i - 1));
                resultArray[i] = (short)(1 - ((mask & ~number) >> (resultArray.Length - i - 1)));
                result += Convert.ToString(resultArray[i]);
            }
        }
        return result;
    }
    static void Main()
    {
        Console.WriteLine("Please enter some number in the interval [-32768;32767]: ");
        short valN = short.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of {0} is: {1}", valN, ShortToBinary(valN));
        //Console.WriteLine("Binary representation of {0} with Convert.ToString(value, base2): {1}", valN, Convert.ToString(valN,2));
        //just to see if it works correctly :-)
    }
}

