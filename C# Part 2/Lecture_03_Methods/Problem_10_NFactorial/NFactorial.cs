using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 10, Lecture 3:
 * Write a program to calculate n! for each n in the range [1..100]. 
 * Hint: Implement first a method that multiplies a number represented as array
 * of digits by given integer number. */

class NFactorial
{
    public static int[] MultiplyInts(int[] number1, int number2)
    {
        int[] number1Reversed = (int[])number1.Clone();
        Array.Reverse(number1Reversed);
        int countOfDigNum2 = 0;
        int number2Copy = number2;
        while (number2Copy > 0)
        {
            countOfDigNum2++;
            number2Copy /= 10;
        }
        List<int[]> myList = new List<int[]>();
        for (int i = 0; i < number1Reversed.Length; i++)
        {
            int tempNum1Num2 = number1Reversed[i] * number2;
            int[] tempRes = new int[number1.Length + countOfDigNum2 + 1];
            for (int j = i; j < tempRes.Length; j++)
            {
                tempRes[j] = tempNum1Num2 % 10;
                tempNum1Num2 /= 10;
            }
            myList.Add(tempRes);
        }
        int add = 0;
        List<int> resultReversed = new List<int>();
        for (int i = 0; i < number1.Length + countOfDigNum2; i++)
        {
            int tempSum = 0;
            for (int j = 0; j < myList.Count; j++)
            {
                tempSum += myList[j][i];
            }
            resultReversed.Add((tempSum + add) % 10);
            add = (tempSum + add) / 10;
        }
        while (add > 0)
        {
            resultReversed.Add(add % 10);
            add /= 10;
        }
        int[] result = (int[])resultReversed.ToArray();
        Array.Reverse(result);
        int index = 0;
        while (index<result.Length)
        {
            if (result[index]!=0)
            {
                break;
            }
            else
            {
                index++;
            }
        }
        int[] resultBetter = new int[result.Length-index];
        for (int i = index; i < result.Length; i++)
        {
            resultBetter[i-index] = result[i];
        }
        return resultBetter;
    }
    public static int[] Factorial(int number)
    {
        int[] initial = { 1 };
        if (number == 1 || number == 0)
        {
            return initial;
        }
        else
        {
            List<int[]> myList = new List<int[]>();
            myList.Add(initial);
            for (int i = 2; i <= number; i++)
            {
                myList.Add(MultiplyInts(myList[i-2], i));
            }
            return myList[number-1];
        }
    }
    static void Main()
    {
        Console.Write("Please enter n to calculate n!: ");
        int valN = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}! is:",valN);
        foreach (var item in Factorial(valN))
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}