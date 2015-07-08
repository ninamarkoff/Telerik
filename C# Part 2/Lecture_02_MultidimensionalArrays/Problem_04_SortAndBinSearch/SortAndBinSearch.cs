using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 4, Lecture 2:
 * Write a program, that reads from the console an array of N integers and an integer K, 
 * sorts the array and using the method Array.BinSearch() finds the largest number in 
 * the array which is ≤ K. */

class SortAndBinSearch
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int valN = int.Parse(Console.ReadLine());
        Console.Write("Please enter K: ");
        int valK = int.Parse(Console.ReadLine());
        int[] myArray = new int[valN];
        Console.WriteLine("Please enter values of the elements of the array:");
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(myArray);
        if (myArray[0]>valK)
        {
            Console.WriteLine("All the elements in the array are greater than {0}!", valK);
        }
        else if (Array.BinarySearch(myArray,valK)>=0)
        {
            Console.WriteLine("The greatest element in the array that is <={0} is {1}", valK, myArray[Array.BinarySearch(myArray,valK)]); 
        }
        else
        {
            Console.WriteLine("The greatest element in the array that is <={0} is {1}", valK, myArray[~(Array.BinarySearch(myArray, valK))-1]); 
        }
    }
}
