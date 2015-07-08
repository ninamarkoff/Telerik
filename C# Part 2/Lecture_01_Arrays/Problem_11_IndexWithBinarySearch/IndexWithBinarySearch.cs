using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 11, Lecture 1:
 * Write a program that finds the index of given element in a sorted array of integers 
 * by using the binary search algorithm (find it in Wikipedia). */


class IndexWithBinarySearch
{
    static void Main()
    {
        Console.WriteLine("Please enter the number of elements in the array: ");
        int valN = int.Parse(Console.ReadLine());
        int[] myArray = new int[valN];
        Console.WriteLine("Please enter the elements of the array: ");
        for (int i = 0; i < valN; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Please enter the searched element: ");
        int searchedValue = int.Parse(Console.ReadLine());
        //int[] sortedArray = new int [valN];
        int[] sortedArray = (int[])myArray.Clone();
        Array.Sort(sortedArray);
        int maxBord = valN - 1;
        int minBord = 0;
        bool elementFound = false;
        int index = 0;

        while (maxBord >= minBord)
        {
            if (searchedValue > sortedArray[(minBord + maxBord) / 2])
            {
                minBord = (minBord + maxBord) / 2 + 1;
            }
            else if (searchedValue < sortedArray[(minBord + maxBord) / 2])
            {
                maxBord = (minBord + maxBord) / 2 - 1;
            }
            else if (searchedValue == sortedArray[(minBord + maxBord) / 2])
            {
                for (int i = 0; i < valN; i++)
                {
                    if (myArray[i] == searchedValue)
                    {
                        index = i;
                        Console.WriteLine("The searched element exist and it is contained in element with index {0}", index);
                    }
                }
                elementFound = true;
                break;
            }
        }
        if (!elementFound)
        {
            Console.WriteLine("There is no such element in the array!");
        }
    }
}

