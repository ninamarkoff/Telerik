using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/* Problem 12, Lecture 8:
 * Write a program that parses an URL address given in the format:
 * 
 * [protocol]://[server]/[resource]
 * 
 * and extracts from it the [protocol], [server] and [resource] elements. 
 * For example from the URL http://www.devbg.org/forum/index.php 
 * the following information should be extracted:
 * [protocol] = "http"
 * [server] = "www.devbg.org"
 * [resource] = "/forum/index.php"
 * */

class ParseURL
{
    static void Main()
    {
        Console.WriteLine("Please enter some URL: ");
        string urlAddress = Console.ReadLine();
        var parts = Regex.Match(urlAddress, "(.*)://(.*?)(/.*)").Groups;

        Console.WriteLine("[protocol] = \"{0}\"\n[server] = \"{1}\"\n[resource] = \"{2}\"", parts[1], parts[2], parts[3]);
    }
}