using System;
using System.Collections.Generic;
using System.IO;

/* Problem 3, Lecture 6:
 * Write a program that enters file name along with its full file path 
 * (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the 
 * console. Find in MSDN how to use System.IO.File.ReadAllText(…).
 * Be sure to catch all possible exceptions and print user-friendly error messages. */

class ReadAndPrintFile
{
    public static void ReadFile()
    {
        StreamReader telerik = new StreamReader(@"C:\Users\Santino\Desktop\Test Telerik Problem 3.txt");
        string fileContent = telerik.ReadToEnd();
        Console.WriteLine(fileContent);
        telerik.Close();
    }
    static void Main()
    {
        try
        {
            ReadFile();
        }
        catch (System.Security.SecurityException)
        {
            Console.WriteLine("Security error was found!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Null reference is passed!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid Path!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The file is not found!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have a permission to open this file!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file path was not found!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The path is in an invalid format!");
        }
    }
}

