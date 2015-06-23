using System;

class Program
{
    static void Main()
    {
        /* Problem 11, Lecture 2:
         * Declare  two integer variables and assign them with 5 and 10 and after that exchange their values. */

        int int1 = 5;
        int int2 = 10;

        Console.WriteLine(int1 + " " + int2);
        int1 = int1 + int2;
        int2 = int1 - int2;
        int1 = int1 - int2;

        Console.WriteLine(int1 + " " + int2);

        // Another way, my favorite - using XOR:

        Console.WriteLine("first: {0}, second: {1}", int1, int2);

        int1 = int1 ^ int2;
        int2 = int1 ^ int2;
        int1 = int1 ^ int2;

        

        Console.WriteLine(int1 + " " + int2);
    }
}

