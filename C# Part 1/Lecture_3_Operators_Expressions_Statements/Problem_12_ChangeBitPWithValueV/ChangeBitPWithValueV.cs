using System;


public class ChangeBitPWithValueV
{
    public static void Main()
    {
        /* Problem 12, Lecture 3:
         * We are given integer number n, value v (v=0 or 1) and a position p.
         * Write a sequence of operators that modifies n to hold the value v at the 
         * position p from the binary representation of n.
	        Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
	        n = 5 (00000101), p=2, v=0 -> 1 (00000001) */

        int number;
        sbyte value, position;
        bool isNumberCorrect;

        do
        {
            Console.WriteLine("Please enter integer number:");
            isNumberCorrect = int.TryParse(Console.ReadLine(), out number);
        }
        while (!isNumberCorrect);

        Console.WriteLine("Please enter a value (0 or 1) v=");
        value = sbyte.Parse(Console.ReadLine());

        Console.WriteLine("Please enter a position p=");
        position = sbyte.Parse(Console.ReadLine());
        int mask = 1 << position;
        int bitAtPosP = mask & number;
        bitAtPosP >>= position;

        if (bitAtPosP == 0 && value == 1)
        {
            mask = 1 << position;
            number |= mask;
        }
        else if (bitAtPosP == 1 && value == 0)
        {
            mask = 1 << position;
            number &= ~mask;
        }

        Console.WriteLine(number);
    }
}

