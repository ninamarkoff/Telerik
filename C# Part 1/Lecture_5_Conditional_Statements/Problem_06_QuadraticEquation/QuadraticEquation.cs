using System;


/* Problem 6, Lecture 5:
 * Write a program that reads the coefficients a, b and c of 
 * a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
 * Write a program that enters the coefficients a, b and c of a quadratic equation
		a*x2 + b*x + c = 0
 * and calculates and prints its real roots.
 * Note that quadratic equations may have 0, 1 or 2 real roots. */


class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Please enter coefficient a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter coefficient b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter coefficient c= ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine();

        if (a != 0 && b != 0 && c != 0)
        {
            Console.WriteLine("The equation is {0}*x^2+{1}*x+{2}=0", a, b, c);
            Console.WriteLine();
            if (b * b - 4 * a * c < 0)
            {
                Console.WriteLine("The equation has irrational roots!");
                Console.WriteLine();
            }
            else if (b * b - 4 * a * c > 0)
            {
                Console.WriteLine("The roots are x1={0} and x2={1}", (-b + Math.Sqrt(b * b - 4 * a * c)) / 2, (-b - Math.Sqrt(b * b - 4 * a * c)) / 2);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The roots are equal, x1=x2={0}", -b / 2 * a);
            }
        }
        else if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("The equation is 0*x^2+0*x+0=0 which means that all possible values of X will satisfy the equation");
                    Console.WriteLine();
                }
                else Console.WriteLine("There is no X that satisfy the equation; No solution!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The equation is {0}*x+{1}=0 and it's linear, not quadratic!", b, c);
                Console.WriteLine("It's solution is x={0}", -c / b);
            }
        }


    }
}

