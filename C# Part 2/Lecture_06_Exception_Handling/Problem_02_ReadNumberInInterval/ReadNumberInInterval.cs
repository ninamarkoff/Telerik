using System;
using System.Collections.Generic;

/* Problem 2, Lecture 6:
 * Write a method ReadNumber(int start, int end) that enters an integer number
 * in given range [start…end]. If an invalid number or non-number text is entered,
 * the method should throw an exception. Using this method write a program that
 * enters 10 numbers:
 * a1, a2, … a10, such that 1 < a1 < … < a10 < 100 */

class ReadNumberInInterval
{
    static int ReadNumber(int start, int end)
    {
        Console.Write("Please enter a number beewen {0} and {1}: ", start, end);
        int number = int.Parse(Console.ReadLine());
        if (number < start || number > end)
        {
            throw new System.ArgumentOutOfRangeException();
        }
        return number;
    }
    static void Main()
    {
        int start = 1;
        int end = 100;
        int counter=0;
        while (counter<10)
        {
            try
            {
                start = ReadNumber(start, end);
                counter++;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine("Out of range: "+ aoore.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Out of range: " + fe.Message);
            }
        }
    }
}

