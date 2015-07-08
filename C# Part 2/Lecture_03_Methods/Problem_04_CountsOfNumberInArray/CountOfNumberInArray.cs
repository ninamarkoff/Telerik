using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 4, Lecture 3:
 * Write a method that counts how many times given number appears in given array.
 * Write a test program to check if the method is working correctly. */

namespace SomeNamespace
{
    public class CountOfNumberInArray
    {
        public static int CountOfGivenNumberInArray(int number, int[] array)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item == number)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main()
        {
            Console.WriteLine("Please enter the number of elements in the array:");
            int valN = int.Parse(Console.ReadLine());
            int[] myArray = new int[valN];
            Random randomGenerator = new Random();
            for (int i = 0; i < valN; i++) //I'm tired of doing this myself, so  - randomization, batka! :-)
            {
                myArray[i] = randomGenerator.Next(1, 10);
                Console.Write("{0} ", myArray[i]);
            }
            Console.WriteLine();
            Console.Write("Please enter element for search in the array: ");
            int valK = int.Parse(Console.ReadLine());
            Console.WriteLine("Element with value {0} is contained {1} times in the given array", valK, CountOfGivenNumberInArray(valK, myArray));

        }
    }
}


