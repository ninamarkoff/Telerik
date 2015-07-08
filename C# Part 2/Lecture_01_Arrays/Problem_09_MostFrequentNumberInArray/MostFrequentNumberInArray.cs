using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 9, Lecture1 :
* Write a program that finds the most frequent number in an array. Example:
{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times) */



class MostFrequentNumberInArray
{
    static void Main()
    {
        Console.WriteLine("Please enter the number of the elements in the array: ");
        int valN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the values of the elements: ");
        List<int> myList = new List<int>();
        List<int> counters = new List<int>();

        for (int i = 0; i < valN; i++)
        {
            myList.Add(int.Parse(Console.ReadLine()));
            counters.Add(1);
        }


        for (int i = 0; i < myList.Count; i++)
        {
            for (int j = i + 1; j < myList.Count; j++)
            {
                if (myList[i] == myList[j])
                {
                    counters[i]++;
                }
            }
            myList.RemoveAll(p => (p.Equals(myList[i]) && p > myList[i]));
        }
        int max = counters.Max();
        Console.WriteLine("The number(s) that appear most frequent are: ");

        for (int i = 0; i < counters.Count; i++)
        {
            if (counters[i] == max)
            {
                Console.WriteLine("{0} -> {1} times", myList[i], counters[i]);
            }
        }


    }
}

