using System;

/* Problem 12, Lecture 6:
 * Write a program that reads from the console a positive integer
 * number N (N < 20) and outputs a matrix like the following:
 *  N=3 -> 123   N=4 ->  1234
 *         234           2345  
 *         456           3456
 *                       4567 
 * */


class SomeMatrix
{
    static void Main()
    {
        Console.Write("Please enter positive integer N<20: ");
        int valN = int.Parse(Console.ReadLine());

        for (int i = 1; i <= valN; i++)
        {
            for (int j = i; j < i + valN; j++)
            {
                Console.Write(Convert.ToString(j).PadLeft(3, ' '));
            }
            Console.WriteLine();
        }
    }
}

