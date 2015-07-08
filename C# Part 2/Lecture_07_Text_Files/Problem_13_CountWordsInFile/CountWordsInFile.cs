using System;
using System.Collections.Generic;
using System.IO;

/* Problem 13, Lecture 7:
 * Write a program that reads a list of words from a file words.txt and finds how many times
 * each of the words is contained in another file test.txt. The result should be written
 * in the file result.txt and the words should be sorted by the number of their occurrences
 * in descending order. Handle all possible exceptions in your methods. */

class CountWordsInFile
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\words.txt");
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");
        List<string> wordsForCount = new List<string>();
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                foreach (var item in line.Split(' '))
                {
                    wordsForCount.Add(item);
                }
                line = reader.ReadLine();
            }
        }
        int[] countOfWordsArray = new int[wordsForCount.Count];
        for (int i = 0; i < countOfWordsArray.Length; i++)
        {
            countOfWordsArray[i] = 0;
        }
        reader = new StreamReader(@"..\..\test.txt");
        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    foreach (var item in line.Split(' '))
                    {
                        if (wordsForCount.Contains(item))
                        {
                            countOfWordsArray[wordsForCount.IndexOf(item)]++;
                        }
                    }
                    line = reader.ReadLine();
                }
                int[] sorted = (int[])countOfWordsArray.Clone();
                Array.Sort(sorted);
                for (int i = sorted.Length - 1; i >= 0; i--)
                {
                    for (int j = 0; j < countOfWordsArray.Length; j++)
                    {
                        if (sorted[i] == countOfWordsArray[j])
                        {
                            writer.WriteLine(wordsForCount[j]);
                            continue;
                        }
                    }
                }
            }
        }
    }
}

