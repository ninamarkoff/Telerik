using System;

public class Program
{
    public static void Main()
    {
        /* Problem 6, Lecture 3:
         * Write an expression that checks if given point (x,  y) is within a circle K(O, 5). */

        double pointX, pointY;

        bool isPointXCorrect = double.TryParse(Console.ReadLine(), out pointX);
        bool isPointYCorrect = double.TryParse(Console.ReadLine(), out pointY);

        if (isPointXCorrect && isPointYCorrect)
        {
            double distance = Math.Sqrt(pointX * pointX + pointY * pointY);

            // The center of the circle is in the center of the coordinate system
            // The variable 'distance' calculates the distance between the given point 
            // and the center of the coordinate system, then it is compared to the length
            // of the radius (5)

            if (distance < 5)
            {
                Console.WriteLine("The point ({0},{1}) is within the circle K(O,5)", pointX, pointY);
            }
            else
            {
                Console.WriteLine("The point ({0},{1}) is outside the circle K(O,5)", pointX, pointY);
            }
        }
        else
        {
            Console.WriteLine("The input data is not correct");
        }
    }
}

