using System;

public class IsDivisibleBy5And7
{
    public static void Main()
    {
        /* Problem 2, Lecture 3:
         * Write a boolean expression that checks for given integer if it can be divided (without remainder)
         * by 7 and 5 in the same time */

        int number;

        Console.WriteLine("Please enter integer number: ");
        bool isCorrectNumber = int.TryParse(Console.ReadLine(), out number);
        while (!isCorrectNumber)
        {
            Console.WriteLine("Please enter correct value (integer number): ");
            isCorrectNumber = int.TryParse(Console.ReadLine(), out number);
        }

        if ((number%5==0) && (number%7==0))
        {
            Console.WriteLine("{0} is divisible by 5 and 7 at the same time", number);
        }
        else
        {
            Console.WriteLine("{0} is not divisible by 5 and 7 at the same time", number);
        }
    }
}

