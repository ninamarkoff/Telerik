using System;


public class InCircleOutOfRectangle
{
    public static void Main()
    {
        /* Problem 9, Lecture 3:
         * Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
         * and out of the rectangle R(top=1, left=-1, width=6, height=2). */

        double axisX, axisY;
        bool isAxisXValid, isAxisYValid;
        do
        {
            Console.WriteLine("Please enter the coordinates of the point:");
            isAxisXValid = double.TryParse(Console.ReadLine(), out axisX);
            isAxisYValid = double.TryParse(Console.ReadLine(), out axisY);
        } while (!isAxisXValid || !isAxisYValid);

        bool isWithinCircle, isOutsideRectangle;

        if (Math.Sqrt(Math.Abs(axisX - 1) * Math.Abs(axisX - 1) + Math.Abs(axisY - 1) * Math.Abs(axisY - 1)) <= 3)
        {
            isWithinCircle = true;
        }
        else
        {
            isWithinCircle = false;
        }

        if (axisX >= 1 && axisX <= 7 && axisY >= -3 && axisY <= -1)
        {
            isOutsideRectangle = false;
        }
        else
        {
            isOutsideRectangle = true;
        }

        if (isWithinCircle && isOutsideRectangle)
        {
            Console.WriteLine("The point {0};{1} is within the circle and outside the rectangle", axisX, axisY);
        }
        else
        {
            Console.WriteLine("The point {0};{1} is not in the circle and outside the rectangle at the same time", axisX, axisY);
        }
    }
}

