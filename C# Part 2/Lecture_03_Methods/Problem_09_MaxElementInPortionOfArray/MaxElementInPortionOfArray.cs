using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 9, Lecture 3:
 * Write a method that return the maximal element in a portion of array of integers 
 * starting at given index. Using it write another method that sorts an array in
 * ascending / descending order. */


class MaxElementInPortionOfArray
{
    public static int MaxElement(int index, List<int> list)
    {
        int max = list[index];
        for (int i = index + 1; i < list.Count; i++)
        {
            if (list[i] > max)
            {
                max = list[i];
            }
        }
        return max;
    }
    public static void SortArrayAsc(List<int> list)
    {
        int[] sortedArray = new int[list.Count];
        int arrIndex = list.Count - 1;
        while (list.Count > 0)
        {
            sortedArray[arrIndex] = MaxElement(0, list);
            arrIndex--;
            list.Remove(MaxElement(0, list));
        }
        for (int i = 0; i < sortedArray.Length; i++)
        {
            list.Add(sortedArray[i]);
        }
    }
    public static void PrintArray(List<int> list)
    {
        foreach (var item in list)
        {
            Console.Write("{0} ", item);
        }
    }

    static void Main()
    {
        Random randGen = new Random();
        int valN = randGen.Next(5, 50); //Here you can change the number of elements in the array
        List<int> myList = new List<int>();
        for (int i = 0; i < valN; i++)
        {
            myList.Add(randGen.Next(1, 100)); //You can change the values of the randomly generated numbers 
        }
        Console.WriteLine("This is the initial array:");
        PrintArray(myList);
        Console.WriteLine();
        Console.WriteLine();
        SortArrayAsc(myList);
        Console.WriteLine("This is the sorted array in ascending order:");
        PrintArray(myList);
        Console.WriteLine();
    }
}

