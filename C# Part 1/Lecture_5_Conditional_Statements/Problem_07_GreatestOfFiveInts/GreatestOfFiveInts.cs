using System;

/* Problem 7, Lecture 5:
 * Write a program that finds the greatest of given 5 variables. */


class GreatestOfFiveInts
{
    static void Main()
    {
        decimal num1 = decimal.Parse(Console.ReadLine());
        decimal num2 = decimal.Parse(Console.ReadLine());
        decimal num3 = decimal.Parse(Console.ReadLine());
        decimal num4 = decimal.Parse(Console.ReadLine());
        decimal num5 = decimal.Parse(Console.ReadLine());

        decimal maxValue = num1;

        if (num2 > maxValue)
        {
            maxValue = num2;
        }
        if (num3 > maxValue)
        {
            maxValue = num3;
        }
        if (num4 > maxValue)
        {
            maxValue = num4;
        }
        if (num5 > maxValue)
        {
            maxValue = num5;
        }

        Console.WriteLine("The biggest number is {0}", maxValue);
    }
}

