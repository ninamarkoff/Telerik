using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 11, Lecture 3:
 * Write a method that adds two polynomials. Represent them as arrays of their coefficients
 * as in the example below:
		x2 + 5 = 1x2 + 0x + 5 -> 1 0 5 */

class SumOfTwoPolynomials
{
    public static void SumOfPolynomials(int[] polCoeff1, int[] polCoeff2)
    {
        int[] polCoeff1Reversed = (int[])polCoeff1.Clone();
        int[] polCoeff2Reversed = (int[])polCoeff2.Clone();
        Array.Reverse(polCoeff1Reversed);
        Array.Reverse(polCoeff2Reversed);
        int minLength = (int)Math.Min(polCoeff1.Length, polCoeff2.Length);
        int maxLength = (int)Math.Max(polCoeff1.Length, polCoeff2.Length);
        bool longerLength1 = false;
        if (polCoeff1.Length > polCoeff2.Length)
        {
            longerLength1 = true;
        }

        int[] sum = new int[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            if (i < minLength)
            {
                sum[i] = polCoeff1Reversed[i] + polCoeff2Reversed[i];
            }
            else if (longerLength1)
            {
                sum[i] = polCoeff1Reversed[i];
            }
            else
            {
                sum[i] = polCoeff2Reversed[i];
            }
        }
        Array.Reverse(sum);
        foreach (var item in sum)
        {
            Console.Write("{0} ", item);
        }
    }
    static void Main()
    {
        Random randGen = new Random();
        int valN = randGen.Next(3, 10);
        int valK = randGen.Next(3, 10);
        int[] poly1 = new int[valN];
        int[] poly2 = new int[valK];
        for (int i = 0; i < valN; i++)
        {
            poly1[i] = randGen.Next(0, 20);
        }
        Console.WriteLine("The indexes of the first polynomial are as follows:");
        foreach (var item in poly1)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 0; i < valK; i++)
        {
            poly2[i] = randGen.Next(0, 20);
        }
        Console.WriteLine("The indexes of the second polynomial are as follows:");
        foreach (var item in poly2)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The indexes of the sum of the two polynomials are as follows:");
        SumOfPolynomials(poly1, poly2);
    }
}

