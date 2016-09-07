using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _01_XML_streams
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader(@"../../Data/data.xml");

            XmlNodeType nodeType = reader.NodeType;
            string nodeName = reader.Name;
            string nodeValue = reader.Value;
            int nodeAtributeCount = reader.AttributeCount;

            Console.WriteLine(" Type: {0} \n Name: {1} \n Value: {2} \n AtributeCount: {3} \n", 
                nodeType, nodeName, nodeValue, nodeAtributeCount
            );

            reader.WhitespaceHandling = WhitespaceHandling.None;

            // GetAttribute
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.AttributeCount > 0)
                {
                    Console.WriteLine(" id:\t   {0}", reader.GetAttribute("id"));
                    Console.WriteLine(" title:\t   {0}", reader.GetAttribute("title"));
                    Console.WriteLine(" category: {0}", reader.GetAttribute("category"));

                    Console.WriteLine();
                }
            }
            reader.Close();

            Console.WriteLine("MoveToNextAttribute");
            XmlTextReader reader2 = new XmlTextReader(@"../../Data/data.xml");

            while (reader2.Read())
            {
                if (reader2.NodeType == XmlNodeType.Element && reader2.AttributeCount > 0)
                {
                    while (reader2.MoveToNextAttribute())
                    {
                        Console.WriteLine(" {0, 10}: {1}",
                            reader2.Name, reader2.Value
                        );
                    }
                    Console.WriteLine();
                }
            }

            reader2.Close();

        }
    }
}
