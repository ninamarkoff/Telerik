using System;

/* Problem 8, Lecture 4:
 * Write a program that reads an integer number n from the console
 * and prints all the numbers in the interval [1..n], each on a 
 * single line. */


public class PrintFrom1ToN
{
    public static void Main()
    {
        Console.Write("Please enter an integer number: N= ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i + 1);
        }
    }
}