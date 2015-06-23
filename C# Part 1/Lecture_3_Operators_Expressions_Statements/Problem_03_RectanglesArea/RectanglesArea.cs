using System;

public class RectanglesArea
{
    public static void Main()
    {
        /* Problem 3, Lecture 3:
            * Write an expression that calculates rectangle’s area by given width and height.*/

        double rectWidth;
        double rectHeight;

        Console.WriteLine("Please enter the width of the rectangle: ");
        bool isRectWitdthCorrect = double.TryParse(Console.ReadLine(), out rectWidth);
        Console.WriteLine("Please enter the height of the rectangle: ");
        bool isRectHeightCorrect = double.TryParse(Console.ReadLine(), out rectHeight);

        if (isRectHeightCorrect && isRectWitdthCorrect)
        {
            Console.WriteLine("The area of the rectangle is {0}", rectHeight * rectWidth);
        }
        else
        {
            Console.WriteLine("The input data is not correct!");
        }

    }
}

