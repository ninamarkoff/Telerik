using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 3, Lecture 2:
 * We are given a matrix of strings of size N x M. Sequences in the matrix we define
 * as sets of several neighbor elements located on the same line, column or diagonal. 
 * Write a program that finds the longest sequence of equal strings in the matrix. */


class MaxSequenceOfEqualStr
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int valN = int.Parse(Console.ReadLine());
        Console.Write("Please enter M: ");
        int valM = int.Parse(Console.ReadLine());
        string[,] matrix = new string[valN, valM];
        Console.WriteLine("Please enter the elements of the matrix:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }
        int sum = 1;
        int bestSum = 1;
        string longestSeq = "";
       

        List<int[]> bestList = new List<int[]>();
        int[] bestArray;



        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int tempRow = i;
                int tempCol = j;
                sum = 1;
                bestSum = 1;

                while (tempCol < matrix.GetLength(1) - 1 && matrix[tempRow, tempCol] == matrix[tempRow, tempCol + 1])
                {
                    sum++;
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                    tempCol++;
                }
                sum = 1;
                tempRow = i;
                tempCol = j;
                while (tempRow < matrix.GetLength(0) - 1 && matrix[tempRow, tempCol] == matrix[tempRow + 1, tempCol])
                {
                    sum++;
                    if (sum > bestSum)
                    {
                        bestSum = sum;                        
                    }
                    tempRow++;
                }
                sum = 1;
                tempRow = i;
                tempCol = j;
                while (tempRow < matrix.GetLength(0) - 1 && tempCol < matrix.GetLength(1) - 1 && matrix[tempRow, tempCol] == matrix[tempRow + 1, tempCol + 1])
                {
                    sum++;
                    if (sum > bestSum)
                    {
                        bestSum = sum;                    
                    }
                    tempRow++;
                    tempCol++;
                }
                sum = 1;
                tempRow = i;
                tempCol = j;
                while (tempRow < matrix.GetLength(0)-1 && tempCol > 0 && matrix[tempRow, tempCol] == matrix[tempRow + 1, tempCol - 1])
                {
                    sum++;
                    if (sum > bestSum)
                    {
                        bestSum = sum;                      
                    }
                    tempRow++;
                    tempCol--;
                }
                bestArray = new int[3];
                bestArray[0] = bestSum;
                bestArray[1] = i;
                bestArray[2] = j;
                bestList.Add(bestArray);
            }
        }
        
        {
            sum = 1;
            for (int i = 0; i < bestList.Count; i++)
            {
                if (bestList[i][0]>sum)
                {
                    sum = bestList[i][0];
                }
            }
            if (sum == 1)
            {
                Console.WriteLine("There is no sequence longer than one element!");
            }
            else
            {
                for (int j = 0; j < bestList.Count; j++)
                {
                    if (bestList[j][0] == sum)
                    {
                        for (int k = 0; k < sum; k++)
                        {
                            longestSeq = longestSeq + matrix[bestList[j][1], bestList[j][2]] + " ";
                        }
                        Console.WriteLine("The longest sequence(s) of equal elements is(are): {0}", longestSeq);
                        longestSeq = "";
                    }
                }
            }
        }

    }
}

