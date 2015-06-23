using System;


public class BitInPositionP
{
    public static void Main()
    {
        /* Problem 11, Lecture 3:
         * Write an expression that extracts from a given integer i the value of a given
         * bit number b. Example: i=5; b=2 -> value=1. */

        int number;
        bool isNumberCorrect;
        int position;

        do
        {
            Console.Write("Please enter integer number i=");
            isNumberCorrect = int.TryParse(Console.ReadLine(), out number);
        }
        while (!isNumberCorrect);

        Console.WriteLine("Please enter bit position to extract, b=");

        position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int resultBit = mask & number;
        resultBit >>= position;

        Console.WriteLine("Value = {0}", resultBit);

    }
}


