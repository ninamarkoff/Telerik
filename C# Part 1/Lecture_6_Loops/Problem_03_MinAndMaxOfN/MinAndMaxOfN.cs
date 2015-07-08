using System;

/* Problem 3, Lecture 6:
 * Write a program that reads from the console a sequence of 
 * N integer numbers and returns the minimal and maximal of them */


class MinAndMaxOfN
{
    static void Main()
    {
        Console.WriteLine("Please enter the count of numbers you want to compare:");
        int countNumber = int.Parse(Console.ReadLine());
        int i = 1, max = 0, min = 0;
        Console.WriteLine("Please enter {0} integers:", countNumber);

        do
        {

            int variable = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                min = variable;
                max = variable;
            }
            if (variable >= max)
            {
                max = variable;
            }
            if (variable <= min)
            {
                min = variable;
            }

            i++;
        } while (i <= countNumber);
        Console.WriteLine("The min value is {0}", min);
        Console.WriteLine("The max value is {0}", max);
    }
}
