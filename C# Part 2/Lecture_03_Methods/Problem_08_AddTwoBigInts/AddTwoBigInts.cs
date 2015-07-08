using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 8, Lecture 3:
 * Write a method that adds two positive integer numbers represented as arrays of digits 
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
 * Each of the numbers that will be added could have up to 10 000 digits. */

class AddTwoBigInts
{
    public static string SumOfTwoReversedBigInts(string number1, string number2)
    {
        char[] number3 = new char[Math.Max(number1.Length, number2.Length) + 1];
        int counter = 0;
        bool maxNumber12 = (number1.Length > number2.Length);
        int maxLengthArr = Math.Max(number1.Length, number2.Length);
        int minLengthArr = Math.Min(number1.Length, number2.Length);
        for (int i = 0; i < maxLengthArr; i++)
        {
            if (i < minLengthArr)
            {
                if (Convert.ToInt16(number1[i]) + Convert.ToInt16(number2[i]) + counter - 96 < 10)
                {
                    number3[i] = Convert.ToChar(Convert.ToInt16(number1[i]) + Convert.ToInt16(number2[i]) + counter - 48);
                    counter = 0;
                }
                else
                {
                    number3[i] = Convert.ToChar((Convert.ToInt16(number1[i]) + Convert.ToInt16(number2[i]) + counter - 96) % 10 + 48);
                    counter = 1;
                }
                if (number1.Length == number2.Length && i == minLengthArr - 1)
                {
                    number3[i + 1] = Convert.ToChar(counter + 48);
                }
            }
            else
            {
                if (maxNumber12)
                {
                    if (Convert.ToInt16(number1[i]) + counter - 48 < 10)
                    {
                        number3[i] = Convert.ToChar(Convert.ToInt16(number1[i]) + counter);
                        counter = 0;
                    }
                    else
                    {
                        number3[i] = Convert.ToChar((Convert.ToInt16(number1[i]) + counter - 48) % 10 + 48);
                        counter = 1;
                        if (i == maxLengthArr - 1)
                        {
                            number3[i + 1] = '1';
                        }
                    }

                }
                else
                {
                    if (Convert.ToInt16(number2[i]) + counter - 48 < 10)
                    {
                        number3[i] = Convert.ToChar(Convert.ToInt16(number2[i]) + counter);
                        counter = 0;
                    }
                    else
                    {
                        number3[i] = Convert.ToChar((Convert.ToInt16(number2[i]) + counter - 48) % 10 + 48);
                        counter = 1;
                        if (i == (maxLengthArr - 1))
                        {
                            number3[i + 1] = '1';
                        }
                    }
                }
            }
        }
        char[] reversedNumber3 = number3.Reverse().ToArray();
        string reversedNumber3AsString = "";
        if (reversedNumber3[0] == '\0')
        {
            for (int i = 1; i < reversedNumber3.Length; i++)
            {
                reversedNumber3AsString += reversedNumber3[i];
            }
        }
        else
        {
            for (int i = 0; i < reversedNumber3.Length; i++)
            {
                reversedNumber3AsString += reversedNumber3[i];
            }
        }
        return reversedNumber3AsString;
    }
    public static void GenerateRandomStringOfDigits(out Random randomGenerator, out string myString)
    {
        randomGenerator = new Random();
        int valN = randomGenerator.Next(1, 10000); //Here you can change the number of digits in each string number generated
        char[] myArray = new char[valN];

        myString = "";
        for (int i = 0; i < valN; i++) //I'm tired of doing this myself, so  - randomization, batka! :-)
        {
            myArray[i] = Convert.ToChar(randomGenerator.Next(48, 57));
            myString += myArray[i];
        }
        Console.WriteLine(myString);
        Console.WriteLine();
    }
    static void Main()
    {  
        Random randomGenerator;
        string myFirstNumber;
        string mySecondNumber;
        GenerateRandomStringOfDigits(out randomGenerator, out myFirstNumber);
        GenerateRandomStringOfDigits(out randomGenerator, out mySecondNumber);        
        Console.WriteLine("The sum of the two reversed integers is: {0}", SumOfTwoReversedBigInts(myFirstNumber, mySecondNumber));
        Console.WriteLine(); 

        /* In this section, you can enter your own values, not randomly generated, 
         * to test my program with desired values :) */

        Console.Write("Please enter some number: ");
        string firstNumber = Console.ReadLine();
        Console.Write("Please enter some other number: ");
        string secondNumber = Console.ReadLine();
        Console.WriteLine("The sum of your reversed numbers is : {0}", SumOfTwoReversedBigInts(firstNumber, secondNumber));
    }
}

