using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 7, Lecture 1:
 * Sorting an array means to arrange its elements in increasing order.
 * Write a program to sort an array. Use the "selection sort" algorithm: 
 * Find the smallest element, move it at the first position, find the smallest
 * from the rest, move it at the second position, etc. */

class SelectionSortOfAnArray
{
    static void Main()
    {
        Console.WriteLine("Please enter the number of elements in the array: ");
        int valN = int.Parse(Console.ReadLine());
        int[] myArray = new int[valN];
        Console.WriteLine("Please enter the values of the elements in the array: ");
        for (int i = 0; i < valN; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }

        int index=0;

        for (int i = 0; i < valN; i++)
        {
            int minElement = myArray[i];

            for (int j = i + 1; j < valN; j++)
            {
                if (minElement > myArray[j])
                {
                    minElement = myArray[j];
                    index = j;
                }
            }
            if (minElement!=myArray[i])
            {
                myArray[i] += myArray[index];
                myArray[index] = myArray[i] - myArray[index];
                myArray[i] -= myArray[index];
            }          
        }
        foreach (var item in myArray)
        {
            Console.Write("{0} ", item);
        }
    }
}

