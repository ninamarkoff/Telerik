using System;

public class OddOrEven
{
    public static void Main()
    {
        /* Problem 1, Lecture 3:
         * Write an expression that checks if given integer is odd or even. */

        int number;

        Console.WriteLine("Please enter integer number: ");
        bool isCorrectNumber = int.TryParse(Console.ReadLine(), out number);        
        while (!isCorrectNumber)
        {
            Console.WriteLine("Please enter correct value (integer number): "); 
            isCorrectNumber = int.TryParse(Console.ReadLine(), out number);
        }

        if (number % 2 == 0)
        {
            Console.WriteLine("{0} is an even number", number);
        }
        else
        {
            Console.WriteLine("{0} is an odd number", number);
        }
    }
}

