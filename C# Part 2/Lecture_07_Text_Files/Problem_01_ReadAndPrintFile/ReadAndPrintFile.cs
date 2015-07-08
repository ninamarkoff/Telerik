using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
/* Problem 1, Lecture 7:
* Write a program that reads a text file and prints on the console its odd lines. */
class ReadAndPrintFile
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\ReadAndPrintFile.cs");
        using (reader)
        {
            int lineNumber = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 == 1)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                    lineNumber++;
                }
                line = reader.ReadLine();
                lineNumber++;
            }
        }
    }
}

