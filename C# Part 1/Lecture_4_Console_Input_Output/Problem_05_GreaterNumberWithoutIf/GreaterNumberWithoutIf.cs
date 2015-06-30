using System;

/* Problem 5, Lecture 4:
 * Write a program that gets two numbers from the console and prints
 * the greater of them. Don’t use if statements. */


public class GreaterNumberWithoutIf
{
    public static void Main()
    {
        Console.Write("Please enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The greater number between {0} and {1} is: {2}",
            firstNumber, secondNumber, (Math.Abs(firstNumber - secondNumber) + firstNumber + secondNumber) / 2);
    }
}