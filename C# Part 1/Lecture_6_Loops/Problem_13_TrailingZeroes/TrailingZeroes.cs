using System;

/* Problem 13, Lecture 6:
 * Write a program that calculates for given N how many trailing zeros
 * present at the end of the number N!. Examples:
 * N = 10 -> N! = 3628800 -> 2
 * N = 20 -> N! = 2432902008176640000 -> 4
 * Does your program work for N = 50 000?
 * Hint: The trailing zeros in N! are equal to the number
 * of its prime divisors of value 5. Think why! */



class TrailingZeroes
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int valN = int.Parse(Console.ReadLine());

        int counter = 0;
        int valNCopy = valN;
        int trailZeroes = 0;

        while (valNCopy / 5 > 0)
        {
            counter++;
            valNCopy /= 5;
        }

        for (int i = 1; i <= counter; i++)
        {
            trailZeroes += valN / (int)Math.Pow(5, i);
        }
        Console.WriteLine("The count of trail zeroes of {0}! is: {1}", valN, trailZeroes);
    }
}

