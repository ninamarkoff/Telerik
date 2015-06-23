using System;


public class ExchangeBits
{
    public static void Main()
    {
        /* *Problem 14, Lecture 3:
         Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1}
         * of given 32-bit unsigned integer. */

        uint number;
        byte bitPositionP, lengthOfSequenceK, bitPositionQ;
        bool isNumberCorrect, isBitPositionPCorrect, isBitPositionQCorrect, isLegthOfSequenceKCorrect;


        do
        {

            Console.WriteLine("Please enter integer between 0 and 4,294,967,295:");
            isNumberCorrect = uint.TryParse(Console.ReadLine(), out number);
            Console.WriteLine("Please enter p (integer between 0 and 30):");
            isBitPositionPCorrect = byte.TryParse(Console.ReadLine(), out bitPositionP);
            Console.WriteLine("Please enter q (integer between 1 and 31, q>p):");
            isBitPositionQCorrect = byte.TryParse(Console.ReadLine(), out bitPositionQ);
            Console.WriteLine("Please enter k ( q+k should not exceed 32):");
            isLegthOfSequenceKCorrect = byte.TryParse(Console.ReadLine(), out lengthOfSequenceK);

        }
        while (!isNumberCorrect || !isBitPositionPCorrect || !isBitPositionQCorrect ||
            !isLegthOfSequenceKCorrect || (bitPositionQ + lengthOfSequenceK > 32) ||
            (bitPositionQ <= bitPositionP) || (bitPositionP > 30) || (bitPositionQ > 31));

        Console.WriteLine("{0} = {1} (2)", Convert.ToString(number).PadLeft(10, ' '), Convert.ToString(number, 2).PadLeft(32, '0'));

        //Exchange has meaning only if the two bits are different!

        for (int i = 0; i <= lengthOfSequenceK - 1; i++)     // k bits should be exchanged (if needed)
        {
            uint mask = (uint)1 << (bitPositionP + i); // Mask for the less significant bit 
            uint lessSignBit = mask & number;
            uint moreSignBit = (mask << (bitPositionQ - bitPositionP)) & number;


            if (((moreSignBit >> bitPositionQ + i) ^ (lessSignBit >> bitPositionP + i)) == 1)
            {
                if ((moreSignBit >> bitPositionQ + i) == 1)
                {
                    number = (number & (~(mask << (bitPositionQ - bitPositionP)))) | mask;
                    //Console.WriteLine("{0} = {1} (2)", number, Convert.ToString(number, 2).PadLeft(32, '0'));

                }
                else
                {
                    number = (number | (mask << (bitPositionQ - bitPositionP))) & (~mask);
                    //Console.WriteLine("{0} = {1} (2)", number, Convert.ToString(number, 2).PadLeft(32, '0'));
                }
            }
        }

        Console.WriteLine("{0} = {1} (2)", Convert.ToString(number).PadLeft(10, ' '), Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}