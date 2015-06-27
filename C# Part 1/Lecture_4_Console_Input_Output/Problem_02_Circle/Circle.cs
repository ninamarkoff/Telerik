using System;

/* Problem 2, Lecture 4:
 * Write a program that reads the radius r of a circle and prints its perimeter and area. */


public class Circle
{
    public static void Main()
    {
        double circleRadius;
        bool isCircleRadiusCorrect = double.TryParse(Console.ReadLine(), out circleRadius);
        Console.WriteLine("The circle with radius {0} has perimeter={1} and area={2}", 
            circleRadius, 2*Math.PI*circleRadius, Math.PI*circleRadius*circleRadius);

    }
}

