using System;
using System.Collections.Generic;
using System.IO;

/* Problem 7, Lecture 7:
* Write a program that replaces all occurrences of the substring "start" with the 
* substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB). */

class ReplaceSubstringInFile
{
    static void Main()
    {                
        StreamReader reader = new StreamReader(@"..\..\Start.txt");
        StreamWriter writer = new StreamWriter(@"..\..\Finish.txt");
        
        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                while (line!=null)
                {
                    writer.WriteLine(line.Replace("start", "finish"));
                    line = reader.ReadLine();  
                }               
            }
        }
    }
}