using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 14, Lecture 1:
 * Write a program that sorts an array of strings using the quick sort algorithm 
 * (find it in Wikipedia). */

class QuicksortOfStringsRework
{
    static void Main()
    {
        Console.WriteLine("Please enter the number of elements in the string array: ");
        int valN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the elements of the array: ");
        List<string> myList = new List<string>();
        string[] mySortedArray = new string[valN];

        for (int i = 0; i < valN; i++)
        {
            myList.Add(Console.ReadLine());
        }
        
        



        foreach (var item in mySortedArray)
        {
            Console.WriteLine(item);
        }
    }
}

