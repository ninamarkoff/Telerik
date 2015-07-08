using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 15, Lecture 1:
 * Write a program that finds all prime numbers in the range [1...10 000 000].
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia). */

class SieveOfEratosthenes
{
    static void Main()
    {
        DateTime start = DateTime.Now;
        List<int> myList = new List<int>();
       
        for (int i = 0; i < 100000; i++)
        {
            myList.Add(i+1);
        }
        Console.Write("1 2 ");
        for (int i = 2; i < myList.Count; i++)
        {
            for (int j = i; j <= i; j++)
            {
                Console.Write("{0} ", myList[j]);
                myList.RemoveAll(p => p > i && p % i == 0);                
            }
        }        
    }
}

