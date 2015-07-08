using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 14, Lecture 1:
 * Write a program that sorts an array of strings using the quick sort algorithm 
 * (find it in Wikipedia). */


class QuickSortOfStringArray
{
    public static void Quicksort(string[] arrElements, int minBord, int maxBord)
    {
        int i = minBord, j = maxBord;
        string pivot = arrElements[(minBord + maxBord) / 2];

        while (i <= j)
        {
            while (arrElements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (arrElements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                string tmp = arrElements[i];
                arrElements[i] = arrElements[j];
                arrElements[j] = tmp;
                i++;
                j--;
            }
        }
        
        if (minBord < j)
        {
            Quicksort(arrElements, minBord, j);
        }

        if (i < maxBord)
        {
            Quicksort(arrElements, i, maxBord);
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter the number of elements in the string array: ");
        int valN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the elements of the array: ");
        string[] myArray = new string[valN];
        for (int i = 0; i < valN; i++)
        {
            myArray[i]=Console.ReadLine();
        }

        Quicksort(myArray, 0, valN-1);
        Console.WriteLine();

        Console.WriteLine("The sorted array is:");
        Console.WriteLine();

        foreach (var item in myArray)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}

