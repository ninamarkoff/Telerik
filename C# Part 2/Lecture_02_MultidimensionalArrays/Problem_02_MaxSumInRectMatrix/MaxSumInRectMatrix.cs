using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 2, Lecture 2:
 * Write a program that reads a rectangular matrix of size N x M and finds in it 
 * the square 3 x 3 that has maximal sum of its elements. */


class MaxSumInRectMatrix
{
    static void Main()
    {
        Console.Write("Please enter N (N>=3): ");
        int valN = int.Parse(Console.ReadLine());
        Console.Write("Please enter M (M>=3): ");
        int valM = int.Parse(Console.ReadLine());
        int[,] matrix = new int[valN, valM];
        int[,] bestSubMatrix = new int[3, 3];

        Console.WriteLine("Please enter the values of the elements in the matrix:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
        int bestSum = int.MinValue;
        int sum=0;
        for (int i = 0; i <= matrix.GetLength(0) - 3; i++)
        {
            for (int j = 0; j <= matrix.GetLength(1) - 3; j++)
            {
                sum = 0;  
                for (int row = i; row < i + 3; row++)
                {
                    for (int col = j; col < j + 3; col++)
                    {                      
                        sum += matrix[row, col];
                    }
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    for (int row = 0; row < 3; row++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            bestSubMatrix[row, col] = matrix[i + row, j + col];
                        }
                    }

                }
            }
            
        }
        Console.WriteLine("The best sum is {0} and it is in the submatrix below:", bestSum);
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write("{0} ", bestSubMatrix[row, col]);
            }
            Console.WriteLine();
        }
        

    }
}

