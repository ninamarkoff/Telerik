using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 5, Lecture 1:
 * Write a program that finds the maximal increasing sequence in an array.
 * Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}. */

class MaxIncreasingSequence
{
    static void Main()
    {
        List<int> myList = new List<int>();
        List<int> counter = new List<int>();

        Console.Write("Please enter the number of elements in the array: ");

        int valN = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the values of the elements of the array: ");

        for (int i = 0; i < valN; i++)
        {
            myList.Add(int.Parse(Console.ReadLine()));
        }
        for (int i = 0; i < valN; i++)
        {
            counter.Add(1);
        }

        int index1 = 0;
        int index2 = 0;
        while (index1 < valN-1)
        {
            if (myList[index1] < myList[index1+1])
            {
                counter[index2]++;
                index1++;
            }
            else
            {
                index1++;
                index2=index1;
            }
        }

        int maxCounter = counter.Max();

        Console.WriteLine("The maximal sequence of increasing elements is {0} elements long", maxCounter);
        for (int i = 0; i < valN; i++)
        {
            if (counter[i] == maxCounter)
            {
                for (int j = 0; j < maxCounter; j++)
                {
                    Console.Write("{0} ", myList[i+j]);
                }
                Console.WriteLine();
            }
        }

    }
}

