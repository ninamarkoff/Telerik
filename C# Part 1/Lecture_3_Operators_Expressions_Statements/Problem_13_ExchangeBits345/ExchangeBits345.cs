using System;


public class ExchangeBits345
{
    public static void Main()
    {
        /* Problem 13, Lecture 3:
         Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. */

        uint number;
        bool isNumberCorrect;

        do
        {
            Console.WriteLine("Please enter integer between 0 and 4,294,967,295:");
            isNumberCorrect = uint.TryParse(Console.ReadLine(), out number);

        }
        while (!isNumberCorrect);

        Console.WriteLine("{0} = {1} (2)", Convert.ToString(number).PadLeft(10, ' '), Convert.ToString(number, 2).PadLeft(32, '0'));

        //Exchange has meaning only if the two bits are different!

        for (int i = 1; i <= 3; i++)     //Three bits should be exchanged (if needed)
        {
            uint mask1 = (uint)1 << (2 + i); //Mask for the less significant bit 
            uint lessSignBit = mask1 & number;
            uint mask2 = ((uint)1 << (23 + i)); //Mask for the more significant bit
            uint moreSignBit = mask2 & number;


            if (((moreSignBit >> 23 + i) ^ (lessSignBit >> 2 + i)) == 1)
            {
                if ((moreSignBit >> 23 + i) == 1)
                {
                    number = (number & (~mask2)) | mask1;
                }
                else
                {
                    number = ((number | mask2) & (~mask1));
                }
            }
        }

        Console.WriteLine("{0} = {1} (2)", Convert.ToString(number).PadLeft(10, ' '), Convert.ToString(number, 2).PadLeft(32, '0'));

    }
}

