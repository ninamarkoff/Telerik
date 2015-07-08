using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


/* Problem 11, Lecture7:
* Write a program that deletes from a text file all words that start with the prefix "test".
* Words contain only the symbols 0...9, a...z, A…Z, _. */


class DeleteWordsWithPrefix
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\InitFile.txt");
        StreamWriter writer = new StreamWriter(@"..\..\ResultFile.txt");
        using (reader)
        {
            using (writer)
            {
                List<string> myList = new List<string>();
                string line = reader.ReadLine();
                string newLine = "";
                while (line != null)
                {
                    foreach (var item in line.Split(' '))
                    {
                        myList.Add(item);
                    }
                    int counter = 0;
                    while (counter < myList.Count)
                    {
                        if (myList[counter].StartsWith("test"))
                        {
                            myList.Remove(myList[counter]);
                        }
                        else
                        {
                            counter++;
                        }
                    }
                    for (int i = 0; i < myList.Count; i++)
                    {
                        if (i != myList.Count - 1)
                        {
                            newLine = newLine + myList[i] + " ";
                        }
                        else
                        {
                            newLine = newLine + myList[i];
                        }
                    }
                    myList.Clear();
                    if (newLine!="")
                    {
                        writer.WriteLine(newLine);
                    }
                    newLine = "";
                    line = reader.ReadLine();
                }
            }
        }
    }
}