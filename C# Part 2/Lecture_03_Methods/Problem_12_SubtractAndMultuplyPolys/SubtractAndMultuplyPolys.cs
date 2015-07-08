using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 12, Lecture 3:
 *Extend the program from Problem 11 to support also subtraction and multiplication
 *of polynomials. */

class SubtractAndMultuplyPolys
{
    public static void SubtractOfPolynomials(int[] polCoeff1, int[] polCoeff2)
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

        int[] subtract = new int[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            if (i < minLength)
            {
                subtract[i] = polCoeff1Reversed[i] - polCoeff2Reversed[i];
            }
            else if (longerLength1)
            {
                subtract[i] = polCoeff1Reversed[i];
            }
            else
            {
                subtract[i] = polCoeff2Reversed[i];
            }
        }
        Array.Reverse(subtract);
        foreach (var item in subtract)
        {
            Console.Write("{0} ", item);
        }
    }
    public static void MultiplyPolynomials(int[] polCoeff1, int[] polCoeff2)
    {
        int[] multiply = new int[polCoeff1.Length + polCoeff2.Length - 1];
        for (int i = 0; i<multiply.Length; i++)
        {
            multiply[i] = 0;
        }
        for (int i = 0; i < polCoeff1.Length; i++)
        {
            for (int j = 0; j < polCoeff2.Length; j++)
            {
                multiply[i + j] += polCoeff1[i] * polCoeff2[j];
            }
        }
        foreach (var item in multiply)
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
        Console.WriteLine("The indexes of the subtraction of the two polynomials are as follows:");
        SubtractOfPolynomials(poly1, poly2);
        Console.WriteLine();
        Console.WriteLine("The indexes of the multiplication of the two polynomials are as follows:");
        MultiplyPolynomials(poly1, poly2);
        Console.WriteLine();
    }
}

