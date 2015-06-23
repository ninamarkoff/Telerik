using System;


public class TrapezoidsArea
{
    public static void Main()
    {
        /* Problem 8, Lecture 3:
         Write an expression that calculates trapezoid's area by given sides a and b and height h. */

        double trapezoidSideA;
        double trapezoidSideB;
        double trapezoidHeight;
        bool isTrSideAValid, isTrSideBValid, isTrHeightValid;

        do
        {
            Console.WriteLine("Please enter trapezoid's side a, side b and height:");
            isTrSideAValid = double.TryParse(Console.ReadLine(), out trapezoidSideA);
            isTrSideBValid = double.TryParse(Console.ReadLine(), out trapezoidSideB);
            isTrHeightValid = double.TryParse(Console.ReadLine(), out trapezoidHeight);
        }
        while (!isTrHeightValid || !isTrSideAValid || !isTrSideBValid);

        Console.WriteLine("The area of the trapezoid with side a={0}, side b={1} and height={2} is: {3}",
            trapezoidSideA, trapezoidSideB, trapezoidHeight, (trapezoidSideA + trapezoidSideB) * trapezoidHeight / 2);
    }
}

