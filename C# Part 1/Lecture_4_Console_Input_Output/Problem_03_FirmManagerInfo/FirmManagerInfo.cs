using System;

/* Problem 3, Lecture 4:
 * A company has name, address, phone number, fax number,
 * web site and manager. The manager has first name,
 * last name, age and a phone number. Write a program 
 * that reads the information about a company and its manager
 * and prints them on the console. */

public class FirmManagerInfo
{
    public static void Main()
    {
        Console.Write("Please enter company's name: ");
        string companyName = Console.ReadLine();
        Console.Write("Please enter company's address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Please enter company's phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Please enter company.s fax number: ");
        string companyFax = Console.ReadLine();
        Console.Write("Please enter company's web site: ");
        string companySite = Console.ReadLine();
        Console.Write("Please enter manager's first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Please enter manager's last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Please enter manager's age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Please enter manager's phone number: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Company: {0}", companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("tel.: {0}", companyPhone);
        Console.WriteLine("fax: {0}", companyFax);
        Console.WriteLine("site: {0}", companySite);
        Console.WriteLine();
        Console.WriteLine("Manager: {0} {1}", managerFirstName,
            managerLastName);
        Console.WriteLine("Age: {0}", managerAge);
        Console.WriteLine("phone: {0}", managerPhone);
    }
}