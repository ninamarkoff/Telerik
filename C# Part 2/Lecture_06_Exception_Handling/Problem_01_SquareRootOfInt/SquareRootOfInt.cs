using System;
using System.Collections.Generic;

/* Problem 1, Lecture 6:
 * Write a program that reads an integer number and calculates and prints
 * its square root. If the number is invalid or negative, print "Invalid number".
 * In all cases finally print "Good bye". Use try-catch-finally. */

class SquareRootOfInt
{
    public static double SquareRoot(int number)
    {
        if (number < 0)
            throw new System.ArgumentOutOfRangeException();
        return Math.Sqrt(number);
    }

    static void Main()
    {
        Console.Write("Please enter integer number to calculate its square root: ");        
        try
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(SquareRoot(num));
        }
        catch (ArgumentOutOfRangeException argEx)
        {
            Console.Error.WriteLine("Invalid number: " + argEx.Message);
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine("Invalid number: " + fe.Message);
        }
        catch(OverflowException oe)
        {
            Console.Error.WriteLine("Invalid number: " + oe.Message);
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}

