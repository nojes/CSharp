using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _01_XML_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DATA_ROOT = "../../Data/";

            // Load data
            XmlDocument doc = new XmlDocument();
            doc.Load(DATA_ROOT + "data.xml");
            XmlNode root = doc.DocumentElement;

            // Get data
            XmlNodeList nodes = doc.GetElementsByTagName("student");

            // Render view
            foreach (XmlNode n in nodes) {
                foreach (XmlAttribute a in n.Attributes) {
                    Console.WriteLine(" {0} => {1}", a.Name, a.Value);
                }
                Console.WriteLine();
            }
        }
    }
}
