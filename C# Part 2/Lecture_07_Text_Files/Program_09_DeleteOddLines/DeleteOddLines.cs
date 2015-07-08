using System;
using System.Collections.Generic;
using System.IO;

/* Problem 9, Lecture 7:
 * Write a program that deletes from given text file all odd lines. 
 * The result should be in the same file. */

class DeleteOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\TextFile.txt");
        List<string> myList = new List<string>();
        using (reader)
        {
            string line = reader.ReadLine();
            int counter = 1;
            while (line != null)
            {
                if (counter % 2 == 0)
                {
                    myList.Add(line);
                }
                counter++;
                line = reader.ReadLine();
            }
        }
        StreamWriter writer = new StreamWriter(@"..\..\TextFile.txt");
        using (writer)
        {
            foreach (var item in myList)
            {
                writer.WriteLine(item);
            }
        }
    }
}