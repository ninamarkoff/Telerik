using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 5, Lecture 3:
 * Write a method that checks if the element at given position in given array of 
 * integers is bigger than its two neighbors (when such exist). */


class CheckElementAtPosition
{
    public static void CheckElement(int position, int[] array)
    {
        if (array.Length == 1)
        {
            Console.WriteLine("There is only one element in the array and it can't be compared!");
        }
        else if (position < 0 || position > array.Length - 1)
        {
            Console.WriteLine("The position you entered is not a valid index in the array!");
        }
        else if (position == 0 && array.Length > 1)
        {
            if (array[position] > array[position + 1])
            {
                Console.WriteLine("The element at position 0 ({0}) has only one neighbour on the right ({1}) and is greater than it", array[position], array[position+1]);
            }
            else
            {
                Console.WriteLine("The element at position 0 ({0}) has only one neighbour on the right ({1}) and is NOT greater than it", array[position],array[position+1]);
            }
        }
        else if (position == (array.Length - 1) && array.Length > 1)
        {
            if (array[position] > array[position - 1])
            {
                Console.WriteLine("The element at position {0} ({1}) has only one neighbour on the left ({2}) and is greater than it", array.Length-1, array[array.Length-1], array[array.Length-2]);
            }
            else
            {
                Console.WriteLine("The element at position {0} ({1}) has only one neighbour on the left ({2}) and is NOT greater than it", array.Length-1, array[array.Length-1], array[array.Length-2]);
            }
        }        
        else
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                Console.WriteLine("The element at position {0} ({1}) is greater than its neighbour elements in the array ({2} ot the left and {3} on the right)", position, array[position], array[position - 1], array[position + 1]);
            }
            else
            {
                Console.WriteLine("The element at position {0} ({1}) is NOT greater than its neighbour elements in the array ({2} ot the left and {3} on the right)", position, array[position], array[position - 1], array[position + 1]);
            }
        }
    }

    static void Main()
    {
        Random randomGenerator = new Random();
        int valN = randomGenerator.Next(1, 100);
        int[] myArray = new int[valN];
        for (int i = 0; i < valN; i++) //I'm tired of doing this myself, so  - randomization, batka! :-)
        {
            myArray[i] = randomGenerator.Next(1, 100);
            Console.Write("{0} ", myArray[i]);
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The length of the array is {0}: ", myArray.Length);
        Console.WriteLine();
        Console.Write("Please enter position: ");
        int pos = int.Parse(Console.ReadLine());
        Console.WriteLine();
        CheckElement(pos, myArray);       
    }

}

