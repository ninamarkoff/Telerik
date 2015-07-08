using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 20, Lecture 1:
 * Write a program that reads two numbers N and K and generates all the variations of K elements
 * from the set [1..N]. Example:
 * N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3} */

class VariationsOfKElements
{
    static void Variations(int[] currentArray, int index, int numN)
    {
        if (index == currentArray.Length) 
        {
            for (int i = 0; i < currentArray.Length; i++) 
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
                Variations(currentArray, index + 1, numN);
            }
        }
    } 
    
    static void Main()
    {
        Console.Write("Please enter the value of N: ");
        int valN = int.Parse(Console.ReadLine());
        Console.Write("Please enter the value of K: ");
        int valK = int.Parse(Console.ReadLine());
        int[] myArray = new int[valK];

        Variations(myArray, 0, valN);
    }
}

