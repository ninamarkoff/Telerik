using System;
using System.Numerics;


/* Problem 5, Lecture 6:
 * Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K). */


class FactorialMultiply
{
    static void Main()
    {
        Console.WriteLine("Please enter positive integer N:");
        int valN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter positive integer K, K>N:");
        int valK = int.Parse(Console.ReadLine());

        BigInteger valFactMult = 1;
        int i = valK - valN + 1, j = 1;

        while (i <= valK)
        {
            valFactMult *= i;
            i++;
        }
        while (j <= valN)
        {
            valFactMult *= j;
            j++;
        }
        Console.WriteLine("The value of {0}!*{1}!/({0}-{1})! is {2}: ", valK, valN, valFactMult);
    }
}
