using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 10, Lecture 1:
 * Write a program that finds in given array of integers a sequence of given sum S
 * (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5} */

class SequenceOfGivenSum
{
    static void Main()
    {
        Console.WriteLine("Please enter the numbers of elements in the array: ");
        int valN = int.Parse(Console.ReadLine());
        int[] myArray = new int[valN];
        Console.WriteLine("Please enter the elements of the array: ");
        for (int i = 0; i < valN; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter the desired subsequent sum S = ");
        int sum = int.Parse(Console.ReadLine());
        int tempSum = 0;

        for (int i = 0; i < valN; i++)
        {
            for (int j = 0; j < valN - i; j++)
            {
                tempSum = 0;

                for (int k = j; k <= j + i; k++)
                {
                    tempSum += myArray[k];
                }
                if (tempSum == sum)
                {
                    for (int l = j; l <= j + i; l++)
                    {
                        Console.Write("{0} ", myArray[l]);
                    }
                    Console.WriteLine();
                }
            }
        }


    }
}

