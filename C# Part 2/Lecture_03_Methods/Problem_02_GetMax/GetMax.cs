using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 2, Lecture 3:
 * Write a method GetMax() with two parameters that returns the bigger of two integers.
 * Write a program that reads 3 integers from the console and prints the biggest of them
 * using the method GetMax(). */

class CGetMax
{
    static int GetMax(int number1, int number2)
    {
        if (number1>number2)
        {
            return number1;
        }
        else
        {
            return number2;
        }
    }
    static void Main()
    {
        Console.WriteLine("Please enter three integers:");
        int var1 = int.Parse(Console.ReadLine());
        int var2 = int.Parse(Console.ReadLine());
        int var3 = int.Parse(Console.ReadLine());


        Console.WriteLine("The greatest value of the three entered is: {0}", GetMax(GetMax(var1,var2),var3));
    }
}

