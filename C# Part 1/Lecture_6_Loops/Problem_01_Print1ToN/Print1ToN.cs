using System;

/* Problem 1, Lecture 6:
 * Write a program that prints all the numbers from 1 to N. */


class Print1ToN
{
    static void Main()
    {
        Console.Write("Please enter positive integer N: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <=number; i++)
        {
            Console.Write("{0,3}",i);
        }
        Console.WriteLine();
    }
}
