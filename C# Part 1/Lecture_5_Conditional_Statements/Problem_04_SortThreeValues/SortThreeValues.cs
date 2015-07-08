using System;

/* Problem 4, Lecture 5:
 * Sort 3 real values in descending order using nested if statements. */


class SortThreeValues
{
    static void Main()
    {
        decimal num1 = decimal.Parse(Console.ReadLine());
        decimal num2 = decimal.Parse(Console.ReadLine());
        decimal num3 = decimal.Parse(Console.ReadLine());

        if (num1 >= num2)
        {
            if (num2 >= num3)
            {
                Console.WriteLine("The three numbers in descending order are: {0}, {1}, {2}", num1, num2, num3);
            }
            else if (num1 > num3)
            {
                Console.WriteLine("The three numbers in descending order are: {0}, {1}, {2}", num1, num3, num2);
            }
            else
            {
                Console.WriteLine("The three numbers in descending order are: {0}, {1}, {2}", num3, num1, num2);
            }
        }
        else
        {
            if (num1 >= num3)
            {
                Console.WriteLine("The three numbers in descending order are: {0}, {1}, {2}", num2, num1, num3);
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The three numbers in descending order are: {0}, {1}, {2}", num2, num3, num1);
            }
            else
            {
                Console.WriteLine("The three numbers in descending order are: {0}, {1}, {2}", num3, num2, num1);
            }
        }

    }
}
