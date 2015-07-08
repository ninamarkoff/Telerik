using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

/* Problem 14, Lecture 3:
 * Write methods to calculate minimum, maximum, average, sum and product of given set
 * of integer numbers. Use variable number of arguments. */

class OperationsOverIntArrays
{
    public static int MinElement(params int[] array)
    {
        int min = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]<min)
            {
                min = array[i];
            }
        }
        return min;
    }
    public static int MaxElement(params int[] array)
    {
        int max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
    public static decimal AverageElement(params int[] array)
    {
        decimal sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum/array.Length;
    }
    public static decimal SumOfElements(params int[] array)
    {
        decimal sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    public static BigInteger ProductOfElements(params int[] array)
    {
        BigInteger product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }
    static void Main()
    {
        Console.WriteLine(MinElement(3,9,1));
        Console.WriteLine(MaxElement(45,57,23));
        Console.WriteLine(AverageElement(3,7,10));
        Console.WriteLine(SumOfElements(1,2,3,4,5));
        Console.WriteLine(ProductOfElements(1,2,3,4,5,6));
    }
}

