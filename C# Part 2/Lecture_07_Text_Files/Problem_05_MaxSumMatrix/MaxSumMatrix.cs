using System;
using System.Collections.Generic;
using System.IO;
/* Problem 5, Lecture 7:
* Write a program that reads a text file containing a square matrix of numbers and finds
* in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
* The first line in the input file contains the size of matrix N. 
* Each of the next N lines contain N numbers separated by space. 
* The output should be a single number in a separate text file. Example:
4
2 3 3 4
0 2 3 4		->	17
3 7 1 2
4 3 3 2
*/
class MaxSumMatrix
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\MAtrix.txt");
        using (reader)
        {
            string line = reader.ReadLine();
            int valN = int.Parse(line);
            int[,] matrix = new int[valN, valN];
            for (int i = 0; i < valN; i++)
            {
                line = reader.ReadLine();
                for (int j = 0; j < valN; j++)
                {
                    matrix[i, j] = int.Parse(Convert.ToString(line.Split(' ')[j]));
                }
            }
            int sum = 0;
            int bestSum = int.MinValue;
            for (int i = 0; i < valN - 1; i++)
            {
                for (int j = 0; j < valN - 1; j++)
                {
                    sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }
            StreamWriter writer = new StreamWriter(@"..\..\Result.txt");
            using (writer)
            {
                writer.Write(bestSum);
            }
        }
    }
}

