using System;

//Problem 9: Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...


public class PrintARow
{
    public static void Main()
    {
        for (int i = 2; i <= 11; i++)
        {
            Console.Write(i * Math.Pow(-1, i));
            Console.Write("  ");
        }
    }
}
