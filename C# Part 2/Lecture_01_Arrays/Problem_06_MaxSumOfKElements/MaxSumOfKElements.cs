using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 6, Lecture 1:
 * Write a program that reads two integer numbers N and K and an array of N elements
 * from the console. Find in the array those K elements that have maximal sum. */

class MaxSumOfKElements
{
    static void Main()
    {
        Console.WriteLine("Please enter value of N: ");
        int valN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value of K: ");
        int valK = int.Parse(Console.ReadLine());
        List<int> myList = new List<int>();


        Console.WriteLine("Please enter values of the elements of the array: ");

        for (int i = 0; i < valN; i++)
        {
            myList.Add(int.Parse(Console.ReadLine()));
        }
        int sum = 0;
        myList.Sort();
        for (int i = valN - valK; i < valN; i++)
        {
            sum += myList[i];
        }
        Console.WriteLine("The maximal sum of {0} elements of the given {1} elements in the array is: {2}", valK, valN, sum);
    }
}

