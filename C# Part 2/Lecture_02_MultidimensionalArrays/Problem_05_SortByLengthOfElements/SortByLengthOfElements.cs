using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 5, Lecture 2:
 * You are given an array of strings. Write a method that sorts the array by the length
 * of its elements (the number of characters composing them). */

class SortByLengthOfElements
{
    static void Main()
    {
        Console.Write("Please enter the number of elements in the string array: ");
        int valN = int.Parse(Console.ReadLine());
        string[] myArray = new string[valN];
        Console.WriteLine("Please enter the elements in the array: ");
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = Console.ReadLine();

        }

        SortStringArrayByLengthOfElements(myArray);
        foreach (var item in myArray)
        {
            Console.Write("{0} ", item);
        }
    }

    private static void SortStringArrayByLengthOfElements(string[] myArray)
    {
        Array.Sort(myArray, CompareStringsByLength);
    }


    private static int CompareStringsByLength(string x, string y)
    {
        int retValue = x.Length.CompareTo(y.Length);
        if (retValue != 0)
        {
            return retValue;
        }
        else
        {
            return x.CompareTo(y);
        }
    }

}


