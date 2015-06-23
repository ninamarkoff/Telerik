using System;

//Problem 12: Write a program to read your age from the console and print how old you will be after 10 years

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age after 10 years will be: {0}", age + 10);
    }
}
