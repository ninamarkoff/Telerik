using System;

/* Problem 3, Lecture 1:
 * Write a program that compares two char arrays lexicographically (letter by letter). */


class ComparisonOfCharArrays
{
    static void Main()
    {
        Console.Write("Please enter the length of the first array: ");
        int valN = int.Parse(Console.ReadLine());
        Console.Write("Please enter the length of the second array: ");
        int valK = int.Parse(Console.ReadLine());
        char[] firstArray = new char[valN];
        char[] secondArray = new char[valK];

        Console.WriteLine("Please enter the values of the elements of the first array:");

        for (int i = 0; i < valN; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("Please enter the values of the elements of the second array: ");

        for (int i = 0; i < valK; i++)
        {
            secondArray[i] = char.Parse(Console.ReadLine());
        }

        int max=-(Math.Abs(valN-valK)-valN-valK)/2;

        for (int i = 0; i < max ; i++)
        {
            if ((int)firstArray[i]<(int)secondArray[i])
            {
                Console.WriteLine("The first array is ordered before the second lexicographically");
                break;
            }
            if ((int)firstArray[i] > (int)secondArray[i])
            {
                Console.WriteLine("The second array is ordered before the first lexicographically");
                break;
            }
            if (i == max - 1 && firstArray[i] == secondArray[i])
            {
                Console.WriteLine("The shorter array is ordered before the longer lexicographically");
            }
        }
    }
}

