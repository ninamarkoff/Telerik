using System;

/* Problem 6, Lecture 6:
 * Write a program that, for a given two integer numbers N and X, 
 * calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N */



class SumNX
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int valN = int.Parse(Console.ReadLine());
        Console.Write("Please enter X: ");
        int valX = int.Parse(Console.ReadLine());

        decimal sum = 1.0m, member = 1.0m;

        for (int i = 1; i <= valN; i++)
        {
            member *= (decimal)i / valX;
            sum += member;
        }
        Console.WriteLine("The sum S = 1 + 1!/{0} + 2!/{0}^2 + … + {1}!/{0}^{1} is: {2}", valX, valN, sum);
    }
}

