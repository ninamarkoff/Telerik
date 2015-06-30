using System;

/* Problem 7, Lecture 4:
 * Write a program that gets a number n and after that gets 
 * more n numbers and calculates and prints their sum. */


public class SumOfNNumbers
{
    public static void Main()
    {
        Console.Write("Please enter integer number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter value for the {0} number: ", i);
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum of the {0} entered numbers is {1}", n, sum);
        Console.WriteLine();
    }
}