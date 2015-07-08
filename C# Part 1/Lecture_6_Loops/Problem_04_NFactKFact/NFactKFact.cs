using System;
using System.Numerics;

/* Problem 4, Lecture 6:
 * Write a program that calculates N!/K! for given N and K (1<K<N). */



class NFactKFact
{
    static void Main()
    {
        Console.WriteLine("Please enter positive integer N:");
        int valN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter positive integer K, K<N:");
        int valK = int.Parse(Console.ReadLine());

        BigInteger valFact = 1;

        for (int i = valK + 1; i <= valN; i++)
        {
            valFact *= i;
        }
        Console.WriteLine("{0}!/{1}!= {2}", valN, valK, valFact);
    }
}

