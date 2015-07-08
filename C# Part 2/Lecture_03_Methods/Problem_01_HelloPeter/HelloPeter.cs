using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 1, Lecture 3:
* Write a method that asks the user for his name and prints “Hello, <name>” 
* (for example, “Hello, Peter!”). Write a program to test this method. */

namespace Program_01_HelloPeter
{

    public class HelloPeter
    {
        public static void Hello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        public static void Main()
        {
            Hello("Peter");
        }
    }
}

