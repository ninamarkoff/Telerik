using System;
using System.Collections.Generic;
using System.Linq;

/* Probem 4, Lecture 5:
 * Write methods that calculate the surface of a triangle by given:
 * Side and an altitude to it; Three sides; Two sides and an angle between them.
 * Use System.Math. */

class SurfaceOfTriangle
{
    public static double TriangAreaBySideAltitude(double side, double altitude)
    {
        return (side * altitude) / 2;
    }

    public static double TriangAreaByThreeeSides(double side1, double side2, double side3)
    {
        double semiP = (side1 + side2 + side3) / 2;
        return Math.Sqrt(semiP * (semiP - side1) * (semiP - side2) * (semiP - side3));
    }

    public static double TriangAreaBy2SidesAngle(double side1, double side2, double angle)
    {
        return (side1 * side2 * Math.Sin((angle * Math.PI) / 180)) / 2;
    }

    static void Main()
    {
        Console.WriteLine("For calculating the area by side and the altitude to it, press 1;");
        Console.WriteLine("For calculating the area by three sides, press 2;");
        Console.WriteLine("For calculating the area by two sides and angle between them, press 3;");
        Console.Write("Please enter your choice to calculate the area of a trinagle: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: Console.WriteLine("Please enter side and altitude:");
                double side = double.Parse(Console.ReadLine());
                double altitude = double.Parse(Console.ReadLine());
                Console.WriteLine("The area is: {0}", TriangAreaBySideAltitude(side, altitude));
                break;
            case 2: Console.WriteLine("Please enter the three sides of the triangle:");
                double firstSide = double.Parse(Console.ReadLine());
                double secondSide = double.Parse(Console.ReadLine());
                double thirdSide = double.Parse(Console.ReadLine());
                Console.WriteLine("The area is: {0}", TriangAreaByThreeeSides(firstSide, secondSide, thirdSide));
                break;
            case 3: Console.WriteLine("Please enter the two sides of the triangle and the angle between them in degrees:");
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double angle = double.Parse(Console.ReadLine());
                Console.WriteLine("The area is: {0}", TriangAreaBy2SidesAngle(side1, side2, angle));
                break;
        }
    }
}

