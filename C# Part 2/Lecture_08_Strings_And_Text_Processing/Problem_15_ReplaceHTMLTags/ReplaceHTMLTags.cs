using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/* Problem 15, Lecture 8:
 * Write a program that replaces in a HTML document given as string all the tags
 * <a href="…">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment:
 * 
 * <p>Please visit <a href="http://academy.telerik. com">our site</a> 
 * to choose a training course. Also visit <a href="www.devbg.org">our forum</a>
 * to discuss the courses.</p>  _-->
 * 
 * <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course.
 * Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p> */

class ReplaceHTMLTags
{
    static void Main()
    {
        string htmlText = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        Console.WriteLine(Regex.Replace(htmlText, "<a href=\"(.*?)\">(.*?)</a>", "[URL=$1]$2[/URL]"));
    }
}