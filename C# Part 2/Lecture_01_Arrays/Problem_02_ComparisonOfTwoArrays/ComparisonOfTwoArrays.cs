using System;

/* Problem 2, Lecture 1:
 * Write a program that reads two arrays from the console
 * and compares them element by element. */

class ComparisonOfTwoArrays
{
    static void Main()
    {
        int[] firstArray = new int[10];
        int[] secondArray = new int[10];

        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 10; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                Console.WriteLine("The two arrays are not equal!");
                break;
            }
            else if (i==9)
            {
                Console.WriteLine("The two arrays are equal");
            }
        }
    }
}

