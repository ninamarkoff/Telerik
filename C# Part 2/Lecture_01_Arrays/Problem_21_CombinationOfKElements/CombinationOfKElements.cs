using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 21, Lecture 1:
 * Write a program that reads two numbers N and K and generates all the combinations of K
 * distinct elements from the set [1..N]. Example:
 * N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, 
 * {3, 4}, {3, 5}, {4, 5} */

class CombinationOfKElements
{
    static void Combinations(int[] currentArray, int index, int numN)
    {
        if (index == currentArray.Length)
        {
            for (int i = currentArray.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", currentArray[i]);
            }
            Console.WriteLine();
        }
        else
        {
            for (int j = 1; j <= numN; j++)
            {
                currentArray[index] = j;
                Combinations(currentArray, index + 1, j - 1);
            }
        }
    }

    static void Main()
    {
        Console.Write("Please enter the value of N: ");
        int valN = int.Parse(Console.ReadLine());
        Console.Write("Please enter the value of K  (K <= N): ");
        int valK = int.Parse(Console.ReadLine());
        int[] myArray = new int[valK];

        Combinations(myArray, 0, valN);

    }
}

