using System;
using System.Text;

public class IsoscelesTriangle
{
    public static void Main()
    {
           /* Problem 9, Lecture 2:
            * Write a program that prints an isosceles triangle of 9 copyright symbols ©.
            * Use Windows Character Map to find the Unicode code of the © symbol.
            * Note: the © symbol may be displayed incorrectly. */

        Console.OutputEncoding = Encoding.Unicode;      

        for (int row = 1; row <= 3; row++)
        {
            for (int col = 1; col <= 5; col++)
            {
                if ((row + col >= 4) && (col <= 2 + row))
                {
                    Console.Write('\u00A9');
                }

                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }

    }
}

