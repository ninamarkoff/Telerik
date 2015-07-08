using System;

/* Problem 9, Lecture 5:
 * We are given 5 integer numbers. Write a program that checks if the sum
 * of some subset of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0. */


class SubsetSumZero
{
    static void Main()
    {
        int num1, num2, num3, num4, num5;

        Console.WriteLine("Please enter the five integer numbers:");

        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        num3 = int.Parse(Console.ReadLine());
        num4 = int.Parse(Console.ReadLine());
        num5 = int.Parse(Console.ReadLine());

        for (int i4 = 0; i4 < 2; i4++)
        {
            for (int i3 = 0; i3 < 2; i3++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    for (int i1 = 0; i1 < 2; i1++)
                    {
                        for (int i0 = 0; i0 < 2; i0++)
                        {
                            int subSum = i0 * num1 + i1 * num2 + i2 * num3 + i3 * num4 + i4 * num5;
                            if (i0 == 1 || i1 == 1 || i2 == 1 || i3 == 1 || i4 == 1)
                            {
                                if (subSum == 0)
                                {
                                    Console.WriteLine("There is a subset which members sum up to zero:");
                                    if (i0 != 0)
                                    {
                                        Console.Write("{0} ", num1);
                                    }
                                    if (i1 != 0)
                                    {
                                        Console.Write("{0} ", num2);
                                    } if (i2 != 0)
                                    {
                                        Console.Write("{0} ", num3);
                                    } if (i3 != 0)
                                    {
                                        Console.Write("{0} ", num4);
                                    } if (i4 != 0)
                                    {
                                        Console.Write("{0} ", num5);
                                    }
                                }
                            }
                        }
                    }

                }

            }

        }

    }
}

