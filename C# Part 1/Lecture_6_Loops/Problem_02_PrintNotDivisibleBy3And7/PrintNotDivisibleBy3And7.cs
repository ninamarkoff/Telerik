using System;

/* Problem 2, Lecture 6:
 * Write a program that prints all the numbers from 1 to N,
 * that are not divisible by 3 and 7 at the same time. */


class PrintNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Please enter positive integer N: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                continue;
            }
            Console.Write("{0,3}", i);
        }
        Console.WriteLine();
    }
}
