using System;
using System.Collections.Generic;
using System.Linq;

/* Problem 6, Lecture 3:
* Write a method that returns the index of the first element in array that is bigger
* than its neighbors, or -1, if there’s no such element.
* Use the method from the previous exercise. */

class IndexOfFirstElement
{
    public static int CheckElement(int position, int[] array)
    {
        if (array.Length == 1)
        {
            //Console.WriteLine("There is only one element in the array and it can't be compared!");
            return -1;
        }
        else if (position < 0 || position > array.Length - 1)
        {
            //Console.WriteLine("The position you entered is not a valid index in the array!");
            return -1;
        }
        else if (position == 0 && array.Length > 1)
        {
            if (array[position] > array[position + 1])
            {
                //Console.WriteLine("The element at position 0 ({0}) has only one neighbour on the right ({1}) and is greater than it", array[position], array[position + 1]);
                return position;
            }
            else
            {
                //Console.WriteLine("The element at position 0 ({0}) has only one neighbour on the right ({1}) and is NOT greater than it", array[position], array[position + 1]);
                return -1;
            }
        }
        else if (position == (array.Length - 1) && array.Length > 1)
        {
            if (array[position] > array[position - 1])
            {
                //Console.WriteLine("The element at position {0} ({1}) has only one neighbour on the left ({2}) and is greater than it", array.Length - 1, array[array.Length - 1], array[array.Length - 2]);
                return position;
            }
            else
            {
                //Console.WriteLine("The element at position {0} ({1}) has only one neighbour on the left ({2}) and is NOT greater than it", array.Length - 1, array[array.Length - 1], array[array.Length - 2]);
                return -1;
            }
        }
        else
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                //Console.WriteLine("The element at position {0} ({1}) is greater than its neighbour elements in the array ({2} ot the left and {3} on the right)", position, array[position], array[position - 1], array[position + 1]);
                return position;
            }
            else
            {
                //Console.WriteLine("The element at position {0} ({1}) is NOT greater than its neighbour elements in the array ({2} ot the left and {3} on the right)", position, array[position], array[position - 1], array[position + 1]);
                return -1;
            }
        }
    }
    public static int FirstIndexOfGreatestElement(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (CheckElement(i, array) == -1)
            {
                return i;
            }

        }
        return -1;
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

        Console.WriteLine("The index of the first element in the array that satisfies the conditions is: {0}", FirstIndexOfGreatestElement(myArray));
        
    }
}

