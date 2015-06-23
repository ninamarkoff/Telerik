using System;

public class PrintASCII
{
    public static void Main()
    {
        /* Problem 12, Lecture 2:
         * Find online more information about ASCII (American Standard Code for Information Interchange) 
         * and write a program that prints the entire ASCII table of characters on the console. */


        for (int asciiSymbol = 0; asciiSymbol < 32; asciiSymbol++)
        {
            string asciiControlSymbol;
            if (asciiSymbol == 0)
                asciiControlSymbol = "\\0";
            else if (asciiSymbol == 7)
                asciiControlSymbol = "\\a";
            else if (asciiSymbol == 8)
                asciiControlSymbol = "\\b";
            else if (asciiSymbol == 9)
                asciiControlSymbol = "\\t";
            else if (asciiSymbol == 10)
                asciiControlSymbol = "\\n";
            else if (asciiSymbol == 11)
                asciiControlSymbol = "\\v";
            else if (asciiSymbol == 12)
                asciiControlSymbol = "\\f";
            else if (asciiSymbol == 13)
                asciiControlSymbol = "\\r";
            else
                asciiControlSymbol = ((char)asciiSymbol).ToString();

            Console.WriteLine
            ("{0} -> {1} {2} -> {3} {4} -> {5} {6} -> {7}",
            asciiSymbol, asciiControlSymbol,
            asciiSymbol + 32, (char)(asciiSymbol + 32),
            asciiSymbol + 64, (char)(asciiSymbol + 64),
            asciiSymbol + 96, (char)(asciiSymbol + 96)
            );
        }
    }
}



