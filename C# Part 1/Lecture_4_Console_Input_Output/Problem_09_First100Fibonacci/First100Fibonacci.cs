using System;
using System.Numerics;

/* Problem 9, Lecture 4:
 Write a program to prlong the first 100 members of the sequence of Fibonacci:
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … */


public class First100Fibonacci
{
    public static void Main()
    {
        BigInteger fibNumber1 = 0;
        BigInteger fibNumber2 = 1;
        BigInteger fibNumber3 = fibNumber1 + fibNumber2;

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(fibNumber1);
            fibNumber1 = fibNumber2;
            fibNumber2 = fibNumber3;
            fibNumber3 = fibNumber1 + fibNumber2;
        }
    }
}