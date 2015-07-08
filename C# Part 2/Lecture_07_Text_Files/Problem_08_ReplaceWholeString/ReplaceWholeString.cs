using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

/* Problem 8, Lecture 7:
 * Modify the solution of the previous problem to replace only whole words (not substrings).*/

class ReplaceWholeString
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
                while (line != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                    line = reader.ReadLine();
                }
            }
        }
    }
}