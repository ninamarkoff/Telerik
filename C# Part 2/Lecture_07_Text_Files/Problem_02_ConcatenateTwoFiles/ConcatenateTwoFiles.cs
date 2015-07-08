using System;
using System.Collections.Generic;
using System.IO;
/* Problem 2, Lecture 7:
 * Write a program that concatenates two text files into another text file.*/
class ConcatenateTwoFiles
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\ConcatenateTwoFiles.cs");
        StreamWriter writer = new StreamWriter(@"..\..\ConcatenatedFiles.txt");
        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }
        reader = new StreamReader(@"..\..\ConcatenateTwoFiles.cs");
        writer = new StreamWriter(@"..\..\ConcatenatedFiles.txt", true);
        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}

