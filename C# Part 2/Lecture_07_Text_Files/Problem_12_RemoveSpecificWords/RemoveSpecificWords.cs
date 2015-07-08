using System;
using System.Collections.Generic;
using System.IO;

/* Problem 12, Lecture 7:
* Write a program that removes from a text file all words listed in given another text file.
* Handle all possible exceptions in your methods. */

class RemoveSpecificWords
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\WordsForDeletion.txt");
        StreamWriter writer = new StreamWriter(@"..\..\ResultFile.txt");
        List<string> myListForDeletion = new List<string>();
        using (reader)
        {             
            string line = reader.ReadLine();
            while (line != null)
            {
                foreach (var item in line.Split(' '))
                {
                    myListForDeletion.Add(item);
                }
                line = reader.ReadLine();                
            }
        }
        reader = new StreamReader(@"..\..\InitFile.txt");
        List <string> finalList = new List<string>(); 
        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                while (line!=null)
                {
                   
                    foreach (var item in line.Split(' '))
                    {
                        if (!myListForDeletion.Contains(item))
                        {
                            finalList.Add(item);
                        }
                    }
                    string newLine = "";
                    for (int i = 0; i < finalList.Count; i++)
                    {
                        if (i!=finalList.Count-1)
                        {
                            newLine += finalList[i] + " ";
                        }
                        else
                        {
                            newLine += finalList[i];
                        }
                    }
                    if (newLine!="")
                    {
                        writer.WriteLine(newLine);                        
                    }
                    line = reader.ReadLine();
                    finalList.Clear();
                    newLine = "";
                }
            }
        }
    }
}