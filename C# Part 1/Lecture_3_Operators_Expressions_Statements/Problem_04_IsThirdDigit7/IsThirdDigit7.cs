using System;

class IsThirdDigit7
{
    static void Main()
    {
        /* Problem 4, Lecture 3:
            * Write an expression that checks for given integer if its third digit
            * (right-to-left) is 7. 
            * E. g. 1732 -> true.*/

        int number;

        bool isNumberCorrect = int.TryParse(Console.ReadLine(), out number);
        while (!isNumberCorrect || number < 100)
        {
            Console.WriteLine("Please enter valid integer number (bigger than 99):");
            isNumberCorrect = int.TryParse(Console.ReadLine(), out number);
        }

        number /= 100;
        if (number % 10 == 7)
        {
            Console.WriteLine("True (The third digit is 7)");
        }
        else
        {
            Console.WriteLine("False (The third digit is NOT 7)");
        }
    }
}

