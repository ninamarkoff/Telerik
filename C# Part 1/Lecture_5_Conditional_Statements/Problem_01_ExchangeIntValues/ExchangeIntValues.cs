using System;

/* Problem 1, Lecture 5:
 * Write an if statement that examines two integer variables and exchanges their values
 * if the first one is greater than the second one. */


public class ExchangeIntValues
{
    public static void Main()
    {
        int number1, number2;

        Console.Write("Please enter the first number: ");
        number1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        number2 = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (number1 == Math.Max(number1, number2))
        {
            number1 = number1 - number2;
            number2 += number1;
            number1 = number2 - number1;
            Console.WriteLine("The exchanged values are:\n\nfirst number= {0}\nsecond number= {1}", number1, number2);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The first number is smaller than the second, so their values remain the same:\nfirst number= {0}\nsecond number= {1} ", number1, number2);
            Console.WriteLine();
        }

    }
}

