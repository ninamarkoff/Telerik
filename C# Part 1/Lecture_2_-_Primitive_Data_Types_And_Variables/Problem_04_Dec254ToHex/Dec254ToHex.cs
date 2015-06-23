using System;

public class Dec254ToHex
{
    public static void Main()
    {
        /* Problem 4, Lecture 2:
         * Declare an integer variable and assign it with the value 254 in hexadecimal format.
         * Use Windows Calculator to find its hexadecimal representation. */
        int var1 = 0xFE; // decimal 254
        Console.WriteLine("{0:X}",var1); //-> FE
        Console.WriteLine(var1); //-> 254

    }
}

