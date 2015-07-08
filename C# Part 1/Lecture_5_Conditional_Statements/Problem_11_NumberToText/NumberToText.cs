using System;

/* Problem 11, Lecture 5:
 * Write a program that applies bonus scores to given scores in the range [1..9].
 * The program reads a digit as an input. If the digit is between 1 and 3,
 * the program multiplies it by 10; if it is between 4 and 6, multiplies it
 * by 100; if it is between 7 and 9, multiplies it by 1000. If it is zero or 
 * if the value is not a digit, the program must report an error.
		Use a switch statement and at the end print the calculated new value
 * in the console. */


class NumberToText
{
    static void Main()
    {
        Console.Write("Please enter number between 0 and 999:");
        int number = int.Parse(Console.ReadLine());


        int digit, digitTens, digitHundreds, remainder100;
        string stringDigit, stringDigitTens = "", stringDigitHundreds = "", stringRemainder100 = "";

        remainder100 = number % 100;

        if (number < 20)
            switch (number)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                case 10: Console.WriteLine("Ten"); break;
                case 11: Console.WriteLine("Eleven"); break;
                case 12: Console.WriteLine("Twelve"); break;
                case 13: Console.WriteLine("Thirteen"); break;
                case 14: Console.WriteLine("Fourteen"); break;
                case 15: Console.WriteLine("Fifteen"); break;
                case 16: Console.WriteLine("Sixteen"); break;
                case 17: Console.WriteLine("Seventeen"); break;
                case 18: Console.WriteLine("Eighteen"); break;
                case 19: Console.WriteLine("Nineteen"); break;

                default: break;
            }

        if (number > 20 && remainder100 < 20 && remainder100 != 0)
        {
            switch (remainder100)
            {
                case 1: stringRemainder100 = " and one"; break;
                case 2: stringRemainder100 = " and two"; break;
                case 3: stringRemainder100 = " and and three"; break;
                case 4: stringRemainder100 = " and four"; break;
                case 5: stringRemainder100 = " and five"; break;
                case 6: stringRemainder100 = " and six"; break;
                case 7: stringRemainder100 = " and seven"; break;
                case 8: stringRemainder100 = " and eight"; break;
                case 9: stringRemainder100 = " and nine"; break;
                case 10: stringRemainder100 = " and ten"; break;
                case 11: stringRemainder100 = " and eleven"; break;
                case 12: stringRemainder100 = " and twelve"; break;
                case 13: stringRemainder100 = " and thirteen"; break;
                case 14: stringRemainder100 = " and fourteen"; break;
                case 15: stringRemainder100 = " and fifteen"; break;
                case 16: stringRemainder100 = " and sixteen"; break;
                case 17: stringRemainder100 = " and seventeen"; break;
                case 18: stringRemainder100 = " and eighteen"; break;
                case 19: stringRemainder100 = " and nineteen"; break;


                default: break;
            }
            switch (number / 100)
            {
                case 1: Console.WriteLine("One hundred" + stringRemainder100); break;
                case 2: Console.WriteLine("Two hundred" + stringRemainder100); break;
                case 3: Console.WriteLine("Three hundred" + stringRemainder100); break;
                case 4: Console.WriteLine("Four hundred" + stringRemainder100); break;
                case 5: Console.WriteLine("Five hundred" + stringRemainder100); break;
                case 6: Console.WriteLine("Six hundred" + stringRemainder100); break;
                case 7: Console.WriteLine("Seven hundred" + stringRemainder100); break;
                case 8: Console.WriteLine("Eight hundred" + stringRemainder100); break;
                case 9: Console.WriteLine("Nine hundred" + stringRemainder100); break;

                default:
                    break;
            }
        }
        if (number >= 20 && number <= 90 && remainder100 >= 20 && remainder100 % 10 == 0)
        {
            switch (remainder100)
            {
                case 20: stringRemainder100 = "Twenty"; break;
                case 30: stringRemainder100 = "Thirty"; break;
                case 40: stringRemainder100 = "Fourty"; break;
                case 50: stringRemainder100 = "Fifty"; break;
                case 60: stringRemainder100 = "Sixty"; break;
                case 70: stringRemainder100 = "Seventy"; break;
                case 80: stringRemainder100 = "Eighty"; break;
                case 90: stringRemainder100 = "Ninety"; break;

                default: break;
            }
        }
        if (number >= 120 && remainder100 >= 20 && remainder100 % 10 == 0)
        {
            switch (remainder100)
            {
                case 20: stringRemainder100 = " and twenty"; break;
                case 30: stringRemainder100 = " and thirty"; break;
                case 40: stringRemainder100 = " and fourty"; break;
                case 50: stringRemainder100 = " and fifty"; break;
                case 60: stringRemainder100 = " and sixty"; break;
                case 70: stringRemainder100 = " and seventy"; break;
                case 80: stringRemainder100 = " and eighty"; break;
                case 90: stringRemainder100 = " and ninety"; break;

                default: break;
            }
            switch (number / 100)
            {
                case 1: Console.WriteLine("One hundred" + stringRemainder100); break;
                case 2: Console.WriteLine("Two hundred" + stringRemainder100); break;
                case 3: Console.WriteLine("Three hundred" + stringRemainder100); break;
                case 4: Console.WriteLine("Four hundred" + stringRemainder100); break;
                case 5: Console.WriteLine("Five hundred" + stringRemainder100); break;
                case 6: Console.WriteLine("Six hundred" + stringRemainder100); break;
                case 7: Console.WriteLine("Seven hundred" + stringRemainder100); break;
                case 8: Console.WriteLine("Eight hundred" + stringRemainder100); break;
                case 9: Console.WriteLine("Nine hundred" + stringRemainder100); break;

                default:
                    break;
            }
        }
        if (remainder100 == 0)
        {
            switch (number / 100)
            {
                case 1: Console.WriteLine("One hundred" + stringRemainder100); break;
                case 2: Console.WriteLine("Two hundred" + stringRemainder100); break;
                case 3: Console.WriteLine("Three hundred" + stringRemainder100); break;
                case 4: Console.WriteLine("Four hundred" + stringRemainder100); break;
                case 5: Console.WriteLine("Five hundred" + stringRemainder100); break;
                case 6: Console.WriteLine("Six hundred" + stringRemainder100); break;
                case 7: Console.WriteLine("Seven hundred" + stringRemainder100); break;
                case 8: Console.WriteLine("Eight hundred" + stringRemainder100); break;
                case 9: Console.WriteLine("Nine hundred" + stringRemainder100); break;

                default:
                    break;
            }
        }
        if (remainder100 > 20 && remainder100 % 10 != 0 && number < 100)
        {
            digitTens = number / 10;
            digit = number % 10;

            switch (digitTens)
            {
                case 3: stringDigitTens = "Thirty"; break;
                case 4: stringDigitTens = "Fourty"; break;
                case 5: stringDigitTens = "Fifty"; break;
                case 6: stringDigitTens = "Sixty"; break;
                case 7: stringDigitTens = "Seventy"; break;
                case 8: stringDigitTens = "Eighty"; break;
                case 9: stringDigitTens = "Ninety"; break;
                default:
                    break;
            }
            switch (digit)
            {
                case 1: stringDigit = "-one";
                    Console.WriteLine(stringDigitTens + stringDigit); break;
                case 2: stringDigit = "-two";
                    Console.WriteLine(stringDigitTens + stringDigit); break;
                case 3: stringDigit = "-three";
                    Console.WriteLine(stringDigitTens + stringDigit); break;
                case 4: stringDigit = "-four";
                    Console.WriteLine(stringDigitTens + stringDigit); break;

                case 5: stringDigit = "-five";
                    Console.WriteLine(stringDigitTens + stringDigit); break;

                case 6: stringDigit = "-six";
                    Console.WriteLine(stringDigitTens + stringDigit); break;

                case 7: stringDigit = "-seven";
                    Console.WriteLine(stringDigitTens + stringDigit); break;

                case 8: stringDigit = "-eight";
                    Console.WriteLine(stringDigitTens + stringDigit); break;

                case 9: stringDigit = "-nine";
                    Console.WriteLine(stringDigitTens + stringDigit); break;

                default:
                    break;
            }
        }
        if (remainder100 > 20 && remainder100 % 10 != 0 && number > 100)
        {
            digitHundreds = number / 100;
            digitTens = (number / 10) % 10;
            digit = number % 10;

            switch (digitHundreds)
            {
                case 1: stringDigitHundreds = "One hundred"; break;
                case 2: stringDigitHundreds = "Two hundred"; break;
                case 3: stringDigitHundreds = "Three hundred"; break;
                case 4: stringDigitHundreds = "Four hundred"; break;
                case 5: stringDigitHundreds = "Five hundred"; break;
                case 6: stringDigitHundreds = "Six hundred"; break;
                case 7: stringDigitHundreds = "Seven hundred"; break;
                case 8: stringDigitHundreds = "Eight hundred"; break;
                case 9: stringDigitHundreds = "Nine hundred"; break;
                default:
                    break;
            }
            switch (digitTens)
            {
                case 2: stringDigitTens = " and twenty"; break;
                case 3: stringDigitTens = " and thirty"; break;
                case 4: stringDigitTens = " and fourty"; break;
                case 5: stringDigitTens = " and fifty"; break;
                case 6: stringDigitTens = " and sixty"; break;
                case 7: stringDigitTens = " and seventy"; break;
                case 8: stringDigitTens = " and eighty"; break;
                case 9: stringDigitTens = " and ninety"; break;
                default:
                    break;
            }
            switch (digit)
            {
                case 1: stringDigit = "-one";
                    Console.WriteLine(stringDigitHundreds + stringDigitTens + stringDigit); break;
                case 2: stringDigit = "-two";
                    Console.WriteLine(stringDigitHundreds + stringDigitTens + stringDigit); break;
                case 3: stringDigit = "-three";
                    Console.WriteLine(stringDigitHundreds + stringDigitTens + stringDigit); break;
                case 4: stringDigit = "-four";
                    Console.WriteLine(stringDigitHundreds + stringDigitTens + stringDigit); break;

                case 5: stringDigit = "-five";
                    Console.WriteLine(stringDigitHundreds + stringDigitTens + stringDigit); break;

                case 6: stringDigit = "-six";
                    Console.WriteLine(stringDigitHundreds + stringDigitTens + stringDigit); break;

                case 7: stringDigit = "-seven";
                    Console.WriteLine(stringDigitHundreds + stringDigitTens + stringDigit); break;

                case 8: stringDigit = "-eight";
                    Console.WriteLine(stringDigitHundreds + stringDigitTens + stringDigit); break;

                case 9: stringDigit = "-nine";
                    Console.WriteLine(stringDigitHundreds + stringDigitTens + stringDigit); break;
                default:
                    break;
            }
        }
    }
}

