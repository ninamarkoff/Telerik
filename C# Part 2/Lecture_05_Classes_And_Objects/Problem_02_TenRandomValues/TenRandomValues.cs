using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 2, Lecture 5:
 * Write a program that generates and prints to the console
 * 10 random values in the range [100, 200]. */

class TenRandomValues
{
    static void Main()
    {
        Random myRandGen = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(myRandGen.Next(100,200));
        }
    }
}

