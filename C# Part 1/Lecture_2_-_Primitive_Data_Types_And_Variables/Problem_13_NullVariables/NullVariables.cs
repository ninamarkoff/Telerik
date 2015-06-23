using System;

public class NullVariables
{
    static void Main()
    {
        /* Problem_13_Lecture 2:
         * Create a program that assigns null values to an integer and to double variables.
         * Try to print them on the console, try to add some values or the null literal to them and see the result. */

        int? intVar1 = null;
        double? doubleVar2 = null;
        Console.WriteLine(intVar1);
        Console.WriteLine(doubleVar2);

        intVar1 = 5;
        doubleVar2 = 10;
        Console.WriteLine(intVar1);
        Console.WriteLine(doubleVar2);

        intVar1 = 7;
        doubleVar2 = 8;
        Console.WriteLine(intVar1);
        Console.WriteLine(doubleVar2);
    }
}

