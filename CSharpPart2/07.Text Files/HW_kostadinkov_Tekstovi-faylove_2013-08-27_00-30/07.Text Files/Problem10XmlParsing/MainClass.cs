/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Text Files
 * Problem 10: Write a program that extracts from given XML file all 
 *              the text without the tags. Example:
 *              <?xml version="1.0"><student><name>Pesho</name>
 *              <age>21</age><interests count="3"><interest> 
 *              Games</instrest><interest>C#</instrest><interest> 
 *              Java</instrest></interests></student>

 */
using System;
using System.Xml;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem10XmlParsing
{
    class MainClass
    {
        static void Main()
        {
            
            using (XmlReader reader = XmlReader.Create(@"..\..\books.xml"))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        //NOTE: Uncomment the following lines to see also the node names

                        //case XmlNodeType.Element:
                        //    Console.Write(reader.Name);
                        //    Console.WriteLine();
                        //    break;
                        
                        case XmlNodeType.Text:
                            Console.Write(reader.Value);
                            Console.WriteLine();
                            break;
                        
                        
                    }
                }
            }
        }
    }
}
