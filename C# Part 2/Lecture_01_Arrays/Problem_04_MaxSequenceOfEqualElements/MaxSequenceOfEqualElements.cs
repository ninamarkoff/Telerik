using System;
using System.Collections.Generic;
using System.Linq;


/* Problem 4, Lecture 1:
 * Write a program that finds the maximal sequence of equal elements in an array.
 * Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}. */



class MaxSequenceOfEqualElements
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
        int index2 = 1;
        while (index2 < valN)
        {
            if (myList[index1] == myList[index2])
            {
                counter[index1]++;
                index2++;
            }
            else
            {
                index1 = index2;
                index2++;
            }
        }

        int maxCounter=counter.Max();
      
        Console.WriteLine("The maximal sequence of equal elements is {0} elements long", maxCounter);
        for (int i = 0; i < valN ; i++)
        {
            if (counter[i]==maxCounter)
            {
                for (int j = 0; j < maxCounter; j++)
			    {
                Console.Write("{0} ", myList[i]);
			    }
                Console.WriteLine();
            }
        }
    }
}

