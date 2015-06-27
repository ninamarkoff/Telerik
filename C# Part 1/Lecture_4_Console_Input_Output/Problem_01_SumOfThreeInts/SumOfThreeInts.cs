using System;

/* Problem 1, Lecture 4:
 * Write a program that reads 3 integer numbers from the console and prints their sum. */

public class SumOfThreeInts
{
    public static void Main()
    {
        int num1, num2, num3;
        bool isNum1Correct, isNum2Correct, isNum3Correct;

        isNum1Correct = int.TryParse(Console.ReadLine(), out num1);
        isNum2Correct = int.TryParse(Console.ReadLine(), out num2);
        isNum3Correct = int.TryParse(Console.ReadLine(), out num3);

        if (isNum1Correct && isNum2Correct && isNum3Correct)
        {
            Console.WriteLine("The sum of the three integers is {0}", num1 + num2 + num3);
        }
        else
        {
            Console.WriteLine("The input data is not in correct format");
        }
        
    }
}

