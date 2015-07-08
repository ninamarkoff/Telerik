using System;

/* Problem 8, Lecture 5:
 * Write a program that, depending on the user's choice inputs int, 
 * double or string variable. If the variable is integer or double, 
 * increases it with 1. If the variable is string, appends "*" at its end. 
 * The program must show the value of that variable as a console output.
 * Use switch statement. */

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please enter your the type of the variable:\n1 - for integer\n2 - for double\n3 - for string");
        byte choiceVar =byte.Parse( Console.ReadLine());

        switch (choiceVar)
        {
            case 1:
                {
                    Console.WriteLine("Please enter the value of the integer:");
                    int intValue=int.Parse(Console.ReadLine());
                    Console.WriteLine("{0}+1={1}",intValue, intValue+1);
                    
                }
                    break;
            case 2:
                {
                    Console.WriteLine("Please enter some double value:");
                    double doubleValue=double.Parse(Console.ReadLine());
                    Console.WriteLine("{0}+1={1}", doubleValue, doubleValue + 1);                   
                }
                    break;
            case 3:
                {
                    Console.WriteLine("Please enter string:"); 
                    string stringValue=Console.ReadLine();
                    Console.WriteLine("{0}->{1}", stringValue, stringValue + "*");                    
                }
                break;                
            default:
                {
                    Console.WriteLine("The input choice is not valid!"); 
                }
                break;
        }

        
    }
}

