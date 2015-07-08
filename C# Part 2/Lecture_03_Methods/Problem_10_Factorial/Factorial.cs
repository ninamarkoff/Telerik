using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 10, Lecture 3:
 * Write a program to calculate n! for each n in the range [1..100]. 
 * Hint: Implement first a method that multiplies a number represented as array
 * of digits by given integer number. */

class Factorial
{
    public static string MultiplyInts(string number1AsString, int number2)
    {
        List<int> number1AsDigitListReversed = new List<int>();
        List<int[]> digitNum1Num2 = new List<int[]>();
        for (int i = number1AsString.Length - 1; i >= 0; i--)
        {
            number1AsDigitListReversed.Add(Convert.ToInt16(number1AsString[i] - 48));
        }
        int countOfDigitsNumber2 = 0;
        int number2Copy = number2;
        while (number2Copy > 0)
        {
            number2Copy /= 10;
            countOfDigitsNumber2++;
        }
        number2Copy = number2;
        for (int i = 0; i < number1AsDigitListReversed.Count; i++)
        {
            int[] num1Num2 = new int[countOfDigitsNumber2 + 1];
            for (int j = 0; j <= countOfDigitsNumber2; j++)
            {
                num1Num2[j] = ((number1AsDigitListReversed[i] * number2) / (int)Math.Pow(10, j)) % 10;
            }
            digitNum1Num2.Add(num1Num2);
        }
        List<int> resultList = new List<int>();
        int additiveValue = 0;
        int tempSum = 0;
        for (int i = 0; i < digitNum1Num2.Count+countOfDigitsNumber2; i++)
        {
            if (i < countOfDigitsNumber2)
            {
                for (int j = 0; j <= i; j++)
                {
                    tempSum += digitNum1Num2[i - j][j];
                }
                resultList.Add((tempSum + additiveValue) % 10);
                additiveValue = (tempSum + additiveValue) / 10;
            }
            else if (i > digitNum1Num2.Count-1)
            {
                for (int j = 0; j < countOfDigitsNumber2-i+digitNum1Num2.Count; j++)
                {
                    tempSum += digitNum1Num2[digitNum1Num2.Count-j-1][j+1];
                }
                resultList.Add((tempSum + additiveValue) % 10);
                additiveValue = (tempSum + additiveValue) / 10;
            }
            else
            {
                for (int j = 0; j <= countOfDigitsNumber2; j++)
                {
                    tempSum += digitNum1Num2[i - j][j];
                }
                resultList.Add((tempSum + additiveValue) % 10);
                additiveValue = (tempSum + additiveValue) / 10;
            }
        }
        if (additiveValue > 0)
        {
            while (additiveValue > 0)
            {
                resultList.Add(additiveValue % 10);
                additiveValue /= 10;
            }
        }
        string result = "";
        for (int i = resultList.Count - 1; i >= 0; i--)
        {
            result += resultList[i];
        }
        return result;
    }
    static void Main()
    {
        Console.WriteLine("{0}", MultiplyInts("100000", 56));
    }
}

