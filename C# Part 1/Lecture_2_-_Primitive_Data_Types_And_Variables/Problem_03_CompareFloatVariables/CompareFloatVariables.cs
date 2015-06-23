using System;

public class CompareFloatVariables
{
    public static void Main()
    {
        /* Problem 3, Lecture 2:
         * Write a program that safely compares floating-point numbers with precision of 0.000001.
         * Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true */
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());
        if (Math.Abs(num1 - num2) < 0.000001)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }        
    }
}

