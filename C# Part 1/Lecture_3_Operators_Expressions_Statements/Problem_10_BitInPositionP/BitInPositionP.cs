using System;


public class BitInPositionP
{
    public static void Main()
    {
        /* Problem 10, Lecture 3:
         * Write a boolean expression that returns if the bit at position p (counting from 0)
         * in a given integer number v has value of 1. Example: v=5; p=1 -> false. */

        int number;
        bool isNumberCorrect;
        int position;

        do
        {
            Console.WriteLine("Please enter integer number v=");
            isNumberCorrect = int.TryParse(Console.ReadLine(), out number);
        } 
        while (!isNumberCorrect);

        Console.WriteLine("Please enter bit position to check if it is 1 or 0, p = ");

        position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int resultBit = mask & number;
        resultBit >>= position;

        if (resultBit == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

