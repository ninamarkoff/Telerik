using System;
using System.Collections.Generic;
using System.IO;
/* Problem 4, Lecture 7:
* Write a program that compares two text files line by line and prints the number
* of lines that are the same and the number of lines that are different. Assume
* the files have equal number of lines. */
class CompareTwoFiles
{
    static void Main()
    {
        string firstFile = @"..\..\FirstFile.txt";
        string secFile = @"..\..\SecondFile.txt";
        StreamReader reader1 = new StreamReader(firstFile);
        StreamReader reader2 = new StreamReader(secFile);
        int counterSame = 0;
        int counterDiff = 0;
        using (reader1)
        {
            using (reader2)
            {
                string line1 = reader1.ReadLine();
                string line2 = reader2.ReadLine();
                while (line1 != null && line2 != null)
                {
                    if (line1 == line2)
                    {
                        counterSame++;
                    }
                    else
                    {
                        counterDiff++;
                    }
                    line1 = reader1.ReadLine();
                    line2 = reader2.ReadLine();
                }
            }
        }
        Console.WriteLine("The lines that are equal in file {0} \r\nand file {1} are: {2}. \r\nThe different lines are: {3}", firstFile, secFile, counterSame, counterDiff);
    }
}

