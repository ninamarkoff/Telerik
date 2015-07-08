using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 6, Lecture 5:
 * You are given a sequence of positive integer values written into a string, 
 * separated by spaces. Write a function that reads these values from given
 * string and calculates their sum. Example:
 * string = "43 68 9 23 318" -> result = 461 */

class SumOfIntsAsString
{
    public static int SumOfIntegersAsStrings(string row)
    {
        string[] newRow = row.Split(' ');
        int sum = 0;
        for (int i = 0; i < newRow.Length; i++)
        {
            sum += int.Parse(newRow[i]);
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Please enter integers, delimited with space:");
        string myRow = Console.ReadLine();
        Console.WriteLine("The sum of the integers is: {0}", SumOfIntegersAsStrings(myRow));
    }
}
