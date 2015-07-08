using System;

/* Problem 8, Lecture 6:
 * Write a program that calculates the greatest common divisor (GCD) 
 * of given two numbers. Use the Euclidean algorithm (find it in Internet). */



class GreatestCommonDivisor
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 < num2)
        {
            num1 += num2;
            num2 = num1 - num2;
            num1 -= num2;
        }

        if (num1 != 0 && num2 != 0)
        {
            while (num1 != num2)
            {
                num1 -= num2;
                if (num1 < num2)
                {
                    num1 += num2;
                    num2 = num1 - num2;
                    num1 -= num2;
                }

            }
            Console.WriteLine("The GCD is: {0}", num1);
            Console.WriteLine();
        }
        else if (num1==0^num2==0)
        {
            Console.WriteLine("The GCD is: {0}", num1);
            Console.WriteLine();
        }
        else if (num1==0&&num2==0)
        {
            Console.WriteLine("Both numbers are 0, therefore GCD does not exist");
            Console.WriteLine();
        }
    }
}

