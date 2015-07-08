using System;

/* Problem 3, Lecture 5:
 * Write a program that finds the biggest of three integers 
 * using nested if statements. */


class BiggestInteger
{
    static void Main()
    {
        int int1 = int.Parse(Console.ReadLine());
        int int2 = int.Parse(Console.ReadLine());
        int int3 = int.Parse(Console.ReadLine());

        if (int1 > int2)
        {
            if (int1 > int3)
            {
                Console.WriteLine("The biggest number is the first one, {0}", int1);
            }
            else if (int1 == int3)
            {
                Console.WriteLine("The first number = third number = {0} and are bigger than the second", int1);
            }
            else
            {
                Console.WriteLine("The biggest number is the third one, {0}", int3);
            }
        }
        else if (int1 == int2)
        {
            if (int1 > int3)
            {
                Console.WriteLine("The first number = second number = {0} and are bigger than than the third", int1);
            }
            else if (int1 < int3)
            {
                Console.WriteLine("The biggest number is the third one, {0}", int3);
            }
            else
            {
                Console.WriteLine("The three numbers are equal");
            }
        }
        else if (int1 < int2)
        {
            if (int2 > int3)
            {
                Console.WriteLine("The biggest number is the second one, {0}", int2);
            }
            else if (int2 == int3)
            {
                Console.WriteLine("The second number = third number = {0} and are bigger than than the first", int2);
            }
            else
            {
                Console.WriteLine("The biggest number is the third one, {0}", int3);
            }
        }
        
    }
}

