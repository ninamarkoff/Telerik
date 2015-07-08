using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 13, Lecture 3:
 * Write a program that can solve these tasks:
 * Reverses the digits of a number
 * Calculates the average of a sequence of integers
 * Solves a linear equation a * x + b = 0
 * Create appropriate methods.
 * Provide a simple text-based menu for the user to choose which task to solve.
 * Validate the input data:
 * The decimal number should be non-negative
 * The sequence should not be empty
 * a should not be equal to 0 */


class SolveThreeTasks
{
    public static decimal ReverseDigits(decimal number)
    {
        decimal result = 0m;
        decimal numberCopy = number;
        int countOfDigits = 0;
        while (numberCopy >= 1)
        {
            countOfDigits++;
            numberCopy /= 10;
        }
        if (countOfDigits == 1)
        {
            return number;
        }
        else
        {
            for (int i = 0; i < countOfDigits; i++)
            {
                result = result * 10 + (number % 10);
                number = (int)number / 10;
            }
        }
        return result;
    }
    public static decimal AverageOfSequence(int[] sequence)
    {
        decimal sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        decimal result = sum / sequence.Length;
        return result;
    }
    public static decimal LinearEquation(decimal a, decimal b)
    {
        return -b / a;
    }
    static void Main()
    {
        Console.WriteLine("Please enter your choice of task to be done:");
        Console.WriteLine("* for reversing the digits of a number, enter R");
        Console.WriteLine("* for calculating the average of a sequence of integers, enter A");
        Console.WriteLine("* for solving linear equation, enter E:");
        string choice = Console.ReadLine();
        while (choice != "R" && choice != "A" && choice != "E")
        {
            Console.WriteLine("Please enter valid choice:");
            choice = Console.ReadLine();
        }
        if (choice == "R")
        {
            Console.WriteLine("Please enter the number you want to reverse:");
            decimal myNumber = decimal.Parse(Console.ReadLine());
            while (myNumber < 0)
            {
                Console.WriteLine("The number should be non-negative. Please enter other number:");
                myNumber = decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine("The reversed number is: {0}", ReverseDigits(myNumber));
        }
        if (choice == "A")
        {
            Console.WriteLine("Please enter the count of numbers that you want to find the average of:");
            int countOfNumbers = int.Parse(Console.ReadLine());
            while (countOfNumbers <= 0)
            {
                Console.WriteLine("Please enter count of numbers > 0:");
                countOfNumbers = int.Parse(Console.ReadLine());
            }
            int[] mySequence = new int[countOfNumbers];
            Console.WriteLine("Please enter the integer numbers of your sequence:");
            for (int i = 0; i < mySequence.Length; i++)
            {
                mySequence[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The average value of your sequence is: {0}", AverageOfSequence(mySequence));
        }
        if (choice == "E")
        {
            Console.WriteLine("Please enter the coefficients of the equation:");
            Console.WriteLine("Please enter a: ");
            decimal myA = decimal.Parse(Console.ReadLine());
            while (myA == 0)
            {
                Console.WriteLine("The coefficient 'a' cannot be zero. Please enter valid value:");
                myA = decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter b:");
            decimal myB = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The value of X in the equation {0}*X + {1} = 0 is: {2}", myA, myB, LinearEquation(myA, myB));
        }
    }
}

