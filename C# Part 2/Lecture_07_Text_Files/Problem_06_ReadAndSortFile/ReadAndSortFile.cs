using System;
using System.Collections.Generic;
using System.IO;


/* Problem 6, Lecture 7:
* Write a program that reads a text file containing a list of strings, 
* sorts them and saves them to another text file. Example:
Ivan			George
Peter			Ivan
Maria	    ->	Maria
George			Peter
*/


class ReadAndSortFile
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\StringFile.txt");
        StreamWriter writer = new StreamWriter(@"..\..\SortedStringFile.txt");
        using (reader)
        {
            using (writer)
            {
                List<string> myList = new List<string>();
                string line = reader.ReadLine();
                while (line!=null)
                {
                    myList.Add(line);
                    line = reader.ReadLine();
                }
                myList.Sort();
                foreach (var item in myList)
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}

