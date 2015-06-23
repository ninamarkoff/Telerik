using System;

public class HelloWorldConcatenation
{
    public static void Main()
    {
        /* Problem 7, Lecture 2:
         * Declare two string variables and assign them with “Hello” and “World”.
         * Declare an object variable and assign it with the concatenation of the first two variables
         * (mind adding an interval). Declare a third string variable and initialize it with the value
         * of the object variable (you should perform type casting). */
        string hello = "Hello";
        string world = "World";
        object concat = hello + ' ' + world;
        Console.WriteLine(concat);
        string objConcat = (string)concat;
        Console.WriteLine(objConcat);
    }
}

