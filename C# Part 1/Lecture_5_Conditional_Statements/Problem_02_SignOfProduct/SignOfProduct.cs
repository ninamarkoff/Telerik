using System;

/*Problem 2, Lecture 5:
* Write a program that shows the sign (+ or -) of the product of three 
* real numbers without calculating it. Use a sequence of if statements. */


class SignOfProduct
{
    static void Main()
    {
        double num1, num2, num3;
        int signNum1, signNum2, signNum3;

        num1 = double.Parse(Console.ReadLine());
        num2 = double.Parse(Console.ReadLine());
        num3 = double.Parse(Console.ReadLine());

        signNum1 = Math.Sign(num1);
        signNum2 = Math.Sign(num2);
        signNum3 = Math.Sign(num3);

        if (signNum1 == 0 || signNum2 == 0 || signNum3 == 0)
        {
            Console.WriteLine("The product of the three numbers is 0, it has no sign!");
        }
        else if ((signNum1 + signNum2 + signNum3 == 3) || (signNum1 + signNum2 + signNum3 == -1))
        {
            Console.WriteLine("The product of the three numbers is '+' ");
        }
        else
        {
            Console.WriteLine("The product of the three numbers is '-'");
        }
    }
}
