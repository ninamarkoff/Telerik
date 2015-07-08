using System;

/* Problem 14, Lecture 6:
* * Write a program that reads a positive integer number N (N < 20) 
* from console and outputs in the console the numbers 1 ... N numbers 
* arranged as a spiral.
* Example for N = 4:
*  1  2  3  4
* 12 13 14  5
* 11 16 15  6
* 10  9  8  7         */


class SpiralMatrix
{

    static void Main()
    {
        Console.Write("Please enter positive integer N<20: ");
        int valN = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[,] matrix = new int[valN, valN];
        matrix[0, 0] = 1;


        for (int i = 0; i < valN / 2; i++)
        {
            if (i >= 1)
            {
                matrix[i, i] = matrix[i, i - 1] + 1;
            }

            for (int j = i + 1; j < valN - i; j++)
            {
                matrix[i, j] = matrix[i, i] + j - i;
                matrix[j, valN - 1 - i] = matrix[i, i] + j - 2 * i + (valN - 1 - i);
                matrix[valN - 1 - i, valN - 1 - j] = matrix[i, i] + j - 3 * i + 2 * (valN - 1 - i);
                if (j != valN - i - 1)
                {
                    matrix[valN - 1 - j, i] = matrix[i, i] + j - 4 * i + 3 * (valN - 1 - i);
                }

            }
        }
        if (valN % 2 == 1)
            matrix[valN / 2, valN / 2] = valN * valN;

        for (int i = 0; i < valN; i++)
        {
            for (int j = 0; j < valN; j++)
            {
                Console.Write(Convert.ToString(matrix[i, j]).PadLeft(5, ' '));
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

