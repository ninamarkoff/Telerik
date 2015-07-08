using System;
using System.Numerics;

/* Problem 7, Lecture 6:
 * Write a program that reads a number N and calculates the sum of the 
 * first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13,
 * 21, 34, 55, 89, 144, 233, 377, …
 * Each member of the Fibonacci sequence (except the first two) is a sum
 * of the previous two members. */



class SumNFibonaccis
{
    static void Main()
    {
        Console.Write("Please enter N=");
        int valN = int.Parse(Console.ReadLine());
        Console.WriteLine();

        BigInteger firstNum = 0;
        BigInteger secondNum = 1;

        if (valN > 1)
        {

            BigInteger sum = 0;

            for (int i = 2; i <= valN; i++)
            {
                secondNum += firstNum;
                firstNum = secondNum - firstNum;
                sum += firstNum;
            }
            Console.WriteLine("The sum of the first {0} Fibonacci members is sum= {1} ", valN, sum);
            Console.WriteLine();
        }
        else if (valN == 1)
        {
            Console.WriteLine("The sum of the first {0} Fibonacci members is sum=0", valN);
            Console.WriteLine();
        }
        else if (valN == 2)
        {
            Console.WriteLine("The sum of the first {0} Fibonacci members is sum=1", valN);
            Console.WriteLine();
        }
    }
}

