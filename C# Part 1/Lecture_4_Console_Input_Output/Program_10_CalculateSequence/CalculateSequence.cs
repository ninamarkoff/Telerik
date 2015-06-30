using System;

/* Problem 10, Lecture 4:
 Write a program to calculate the sum (with accuracy of 0.001):
 * 1 + 1/2 - 1/3 + 1/4 - 1/5 + ... */


class CalculateSequence
{
    static void Main()
    {
        double sum = 0;
        double tempSum=1.0;
        int sign = 1;
        int i = 2;
        while (Math.Abs(tempSum-sum)>0.001)
        {
            sum = tempSum;
            tempSum += sign * (1.0 / i);
            sign *= -1;
            i++;
            
        }
        Console.WriteLine("{0:0.000}",sum);
    }
}

