using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

/* Problem 10, Lecture 7:
 * Write a program that extracts from given XML file all the text without the tags. Example:
 * <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>
 * Games</instrest><interest>C#</instrest><interest> Java</instrest></interests></student> */

class ExtractFromXML
{
    static void Main()
    {
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.DtdProcessing = DtdProcessing.Parse;
        settings.XmlResolver = null;
        XmlReader reader = XmlReader.Create(new StreamReader(@"..\..\XMLLog.xml"),settings);
        StreamWriter writer = new StreamWriter(@"..\..\ResultLog.txt");
        using (reader)
        {
            using (writer)
            {
                while (!reader.EOF)
                {
                    reader.Read();
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        writer.WriteLine(reader.Value);
                    }
                }
            }
        }
    }
}

