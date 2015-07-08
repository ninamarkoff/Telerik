using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 1, Lecture 2:
 * Write a program that fills and prints a matrix of size (n, n) as shown below:
 * (examples for n = 4)
 * 
 * A)              B)               C)                D)
 *   1  5  9  13     1  8   9  16     7  11  14  16     1  12  11  10
 *   2  6 10  14     2  7  10  15     4   8  12  15     2  13  15   9
 *   3  7 11  15     3  6  11  14     2   5   9  13     3  14  16   8
 *   4  8 12  16     4  5  12  13     1   3   6  10     4   5   6   7
 *   */

class FillAndPrintMatrixesIn4Ways
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int valN = int.Parse(Console.ReadLine());
        int[,] matrix = new int[valN, valN];


        PrintFirstMatrix(matrix);
        PrintSecondMatrix(matrix);
        PrintThirdMatrix(matrix);
        PrintFourthMatrix(matrix);


    }

    private static void PrintFourthMatrix(int[,] matrix)
    {
        int start = 1;

        for (int i = 1; i <= matrix.GetLength(0) / 2; i++)
        {
            int row = i - 1;
            int col = i - 1;
            while (row <= matrix.GetLength(0) - i)
            {
                matrix[row, col] = start;
                start++;
                row++;
            }
            row--;
            col++;
            while (col <= matrix.GetLength(0) - i)
            {
                matrix[row, col] = start;
                start++;
                col++;
            }
            col--;
            row--;
            while (row >= i - 1)
            {
                matrix[row, col] = start;
                start++;
                row--;
            }
            row++;
            col--;
            while (col > i - 1)
            {
                matrix[row, col] = start;
                start++;
                col--;
            }


        }
        if (matrix.GetLength(0) % 2 == 1)
        {
            matrix[matrix.GetLength(0) / 2, matrix.GetLength(0) / 2] = matrix.GetLength(0) * matrix.GetLength(0);
        }
        Console.WriteLine();
        Console.WriteLine("Printing the fourth matrix:");
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private static void PrintThirdMatrix(int[,] matrix)
    {
        int start = 1;
        for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
        {
            for (int j = 0; j < matrix.GetLength(0) - i; j++)
            {
                matrix[i + j, j] = start;
                start++;
            }
        }
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0) - i; j++)
            {
                matrix[j, i + j] = start;
                start++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Printing the third matrix:");
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    private static void PrintSecondMatrix(int[,] matrix)
    {
        int start = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i % 2 == 0)
                {
                    matrix[j, i] = start;
                    start++;
                    if (j == matrix.GetLength(0) - 1)
                    {
                        start += matrix.GetLength(0) - 1;
                    }
                }
                else
                {
                    matrix[j, i] = start;
                    start--;
                    if (j == matrix.GetLength(0) - 1)
                    {
                        start += matrix.GetLength(0) + 1;
                    }
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Printing the second matrix:");
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private static void PrintFirstMatrix(int[,] matrix)
    {
        int start = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[j, i] = start;
                start++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Printing the first matrix:");
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

