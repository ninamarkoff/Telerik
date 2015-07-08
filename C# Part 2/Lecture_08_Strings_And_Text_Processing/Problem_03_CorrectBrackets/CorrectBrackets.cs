using System;
using System.Collections.Generic;

/* Problem 3, Lecture 8:
 * Write a program to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d).
 * Example of incorrect expression: )(a+b)). */

class CorrectBrackets
{
    static void Main()
    {
        int countOpBr = 0;
        int countClBr = 0;
        Console.WriteLine("Please enter some expression: ");
        string expression = Console.ReadLine();
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i]=='(')
            {
                countOpBr++;
            }
            if (expression[i]==')')
            {
                countClBr++;
            }
            if (countClBr > countOpBr)
            {
                Console.WriteLine("The expression is NOT correct!");
                break;
            }
        }
        if (countOpBr==countClBr)
        {
            Console.WriteLine("The expression is correct!");
        }
    }
}