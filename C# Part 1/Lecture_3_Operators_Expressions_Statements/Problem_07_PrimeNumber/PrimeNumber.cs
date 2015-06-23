using System;


public class PrimeNumber
{
    public static void Main()
    {
        /* Problem 7, Lecture 3:
         * Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.*/

        int number;
        bool isNumberCorrect;
        do
        {
            Console.WriteLine("Please enter integer between 0 and 100:");
            isNumberCorrect = int.TryParse(Console.ReadLine(), out number);
        }
        while (!isNumberCorrect || number > 101 || number < 0);

        bool isOneTwoOrThree = ((number == 1) || (number == 2) || (number == 3));

        int sqrtNumber = (int)Math.Sqrt(number);
        for (int i = 2; i <= sqrtNumber; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine("The number {0} is NOT a prime number", number);
                break;
            }
            else if ((i == sqrtNumber))
            {
                Console.WriteLine("The number {0} is prime", number);
            }
        }

        if (isOneTwoOrThree)
        {
            Console.WriteLine("The number {0} is prime", number);
        }
    }
}

