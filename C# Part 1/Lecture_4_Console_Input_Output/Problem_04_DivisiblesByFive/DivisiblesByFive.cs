using System;

/* Problem 4, Lecture 4:
 * Write a program that reads two positive integer numbers and prints 
 * how many numbers p exist between them such that the reminder of 
 * the division by 5 is 0 (inclusive). Example: p(17,25) = 2. */


public class DivisiblesByFive
{
    public static void Main()
    {
        Console.Write("Please enter the interval beginning number:  ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the interval ending number:  ");
        int secondNumber = int.Parse(Console.ReadLine());

        int countOfNumbers = 0;
        int divisibleBy5 = firstNumber;

        while (divisibleBy5 % 5 != 0 && divisibleBy5 <= secondNumber)
        {
            divisibleBy5++;
        }

        while (divisibleBy5 <= secondNumber)
        {
            divisibleBy5 += 5;
            countOfNumbers++;
        }

        Console.WriteLine("The count of numbers in the interval [{0}; {1}] that are divisible by 5 is: {2}",
        firstNumber, secondNumber, countOfNumbers);
    }
}