using System;


public class CheckBit3
{
    public static void Main()
    {
        /* Problem 5, Lecture 3:
         * Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0. */

        int number;
        int bitToBeChecked = 3;

        bool isNumberCorrect = int.TryParse(Console.ReadLine(), out number);
        while (!isNumberCorrect)
        {
            Console.WriteLine("The input data is not valid. Please enter integer number: ");
            isNumberCorrect = int.TryParse(Console.ReadLine(), out number);
        }

        int mask = 1 << bitToBeChecked;
        int result = mask & number;
        result >>= bitToBeChecked;
        Console.WriteLine("The third bit of {0} is {1}", number, result);
    }
}

