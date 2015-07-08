using System;
using System.Collections.Generic;
using System.IO;
/* Problem 3, Lecture 7:
* Write a program that reads a text file and inserts line numbers in front
* of each of its lines. The result should be written to another text file. */
class InsertLineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\InsertLineNumbers.cs");
        StreamWriter writer = new StreamWriter(@"..\..\TextFile.txt");
        using (reader)
        {
            using (writer)
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }

    }
}