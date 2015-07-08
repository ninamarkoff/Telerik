using System;
using System.Collections.Generic;
using System.Linq;


class VariationsOfKElementsRework
{
    static void Main()
    {
        Console.Write("Please enter the value of N: ");
        int valN = int.Parse(Console.ReadLine());
        Console.Write("Please enter the value of K: ");
        int valK = int.Parse(Console.ReadLine());
        int[] myArray = new int[valK];
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = 1;
        }
        foreach (var item in myArray)
        {
            Console.Write("{0} ",item);            
        }
        Console.WriteLine();


        for (int i = 0; i < (int)Math.Pow(valN, valK) - 1; i++)
        {
            if (!myArray.All(p => p == valN))
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
                        if (myArray[j] < valN)
                        {
                            myArray[j] += 1;
                            for (int k = j + 1; k <= valK - 1; k++)
                            {
                                myArray[k] = 1;
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
}

