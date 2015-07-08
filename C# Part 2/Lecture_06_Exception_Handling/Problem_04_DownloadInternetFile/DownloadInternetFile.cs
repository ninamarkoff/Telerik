using System;
using System.Collections.Generic;
using System.Net;

/* Problem 4, Lecture 6:
 * Write a program that downloads a file from Internet 
 * (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory.
 * Find in Google how to download files in C#. Be sure to catch all exceptions and
 * to free any used resources in the finally block. */

class DownloadInternetFile
{
    public static void DownloadStringURL()
    {
        var result = string.Empty;
        using (var webClient = new WebClient())
        {
            result = webClient.DownloadString("http://www.1800pocketpc.com/blog/wp-content/uploads/2011/10/telerik-logo.png");
        }
    }
    static void Main()
    {
        try
        {
            DownloadStringURL();
        }
        catch (WebException webex)
        {
            if (webex.Status == WebExceptionStatus.ProtocolError)
            {
                if (((HttpWebResponse)webex.Response).StatusCode == HttpStatusCode.NotFound)
                {
                    // handle error 404
                    Console.WriteLine(webex);
                    Console.WriteLine("Invalid address or empty file!");
                }
            }
            else if (webex.Status == WebExceptionStatus.NameResolutionFailure)
            {
                // handle name resolution failure
                Console.WriteLine(webex);
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address can not be null");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("This method does not support simultaneous downloads.");
        }
    }    
}

