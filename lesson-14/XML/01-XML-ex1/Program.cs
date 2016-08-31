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

            // Load document
            XmlDocument doc = new XmlDocument();
            doc.Load(DATA_ROOT + "data.xml");
            XmlNode root = doc.DocumentElement;

            // Get elements from document
            XmlNodeList nodes = doc.GetElementsByTagName("student");

            // Display elements
            foreach (XmlNode n in nodes) {
                foreach (XmlAttribute a in n.Attributes) {
                    Console.WriteLine(" {0} => {1}", a.Name, a.Value);
                }
                Console.WriteLine();
            }


            //// New element
            //XmlElement s = doc.CreateElement("student");
            //XmlAttribute id = doc.CreateAttribute("id");
            //XmlAttribute fname = doc.CreateAttribute("fname");
            //XmlAttribute lname = doc.CreateAttribute("lname");
            //XmlAttribute age = doc.CreateAttribute("age");
            //XmlAttribute rate = doc.CreateAttribute("rate");

            //Console.WriteLine("\n Input data: ");

            //// Get 'new element' data 
            //Console.Write(" id: ");
            //id.Value = Console.ReadLine();
            //Console.Write(" fname: ");
            //fname.Value = Console.ReadLine();
            //Console.Write(" lname: ");
            //lname.Value = Console.ReadLine();
            //Console.Write(" age: ");
            //age.Value = Console.ReadLine();
            //Console.Write(" rate: ");
            //rate.Value = Console.ReadLine();

            //// Append attributes of 'new element'
            //s.Attributes.Append(id);
            //s.Attributes.Append(fname);
            //s.Attributes.Append(lname);
            //s.Attributes.Append(age);
            //s.Attributes.Append(rate);

            //// Append 'new element'
            //root.AppendChild(s);

            //// Save xml document
            //doc.Save(DATA_ROOT + "data.xml");


            // Remove element
            XmlNode x = root.ChildNodes[2];
            root.RemoveChild(x);

            doc.Save(DATA_ROOT + "data.xml");
        }
    }
}
