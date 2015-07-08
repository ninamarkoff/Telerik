using System;
using System.Collections.Generic;
using System.Linq;


class CombinOfKElementsRework
{
    static void Main()
    {
        Console.Write("Please enter the value of N: ");
        int valN = int.Parse(Console.ReadLine());
        Console.Write("Please enter the value of K (K <= N): ");
        int valK = int.Parse(Console.ReadLine());
        int[] myArray = new int[valK];
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i + 1;
        }
        foreach (var item in myArray)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();

        long limit1 = 1, limit2 = 1;
        for (int i = valK + 1; i <= valN; i++)
        {
            limit1 *= i;
        }
        for (int i =  1; i <= valN - valK; i++)
        {
            limit2 *= i;
        }


        for (int i = 0; i < limit1/limit2; i++)
        {

            if (myArray[valK - 1] + 1 <= valN)
            {
                myArray[valK - 1] += 1;
                foreach (var item in myArray)
                {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = valK - 2; j >= 0; j--)
                {
                    if (myArray[j] - j <= valN-valK)
                    {
                        myArray[j] += 1;
                        for (int k = j + 1; k <= valK - 1; k++)
                        {
                            myArray[k] = myArray[k - 1] + 1;
                        }
                        foreach (var item in myArray)
                        {
                            Console.Write("{0} ", item);
                        }
                        Console.WriteLine();
                        break;
                    }
                    
                    
                }
            }

        }
    }
}

