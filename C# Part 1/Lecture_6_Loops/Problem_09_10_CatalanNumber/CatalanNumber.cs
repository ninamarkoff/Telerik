using System;
using System.Numerics;

/* Problem 9-10, Lecture 6:
 * In the combinatorial mathematics, the Catalan numbers are calculated by 
 * the following formula:
 * C(n)=(2n)!/((n+1)!*n!) for n>=0.
 * Write a program to calculate the Nth Catalan number by given N. */


class CatalanNumber
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int valN = int.Parse(Console.ReadLine());

        BigInteger valCatalanNumberN = 1;

        if (valN > 0)
        {
            for (int i = 1; i <= valN; i++)
            {
                valCatalanNumberN = (valCatalanNumberN * (BigInteger)(valN + i)) / i;
            }
            valCatalanNumberN /= (valN + 1);
            Console.WriteLine("The {0}-th Catalan number is: {1}", valN, valCatalanNumberN);
        }
        else if (valN == 0)
        {
            Console.WriteLine("The {0}-th Catalan number is: 1", valN);
        }
    }
}

