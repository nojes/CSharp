using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _02_GoodsCatalog
{
    class Catalog
    {
        const string DATA_ROOT = "../../Data/";
        string fileName = "goods.xml";

        static uint productId = 0;

        List<Product> products;

        public Catalog()
        {
            products = new List<Product>();
        }

        public void Init()
        {
            XmlTextReader reader = new XmlTextReader(DATA_ROOT + fileName);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.AttributeCount > 0)
                {
                    productId++;
                    Product p = new Product(
                        Convert.ToUInt32(reader.GetAttribute("id")),
                        reader.GetAttribute("category"),
                        reader.GetAttribute("name"),
                        reader.GetAttribute("vendor"),
                        Convert.ToDouble(reader.GetAttribute("price")),
                        Convert.ToUInt32(reader.GetAttribute("quantity"))
                    );
                    products.Add(p);
                }
            }
            reader.Close();
        }

        public void AddProduct(Product p)
        {
            p.Id = ++productId;
            products.Add(p);
        }

        public void EditProduct(Product p)
        {
            // ...
        }

        public void Update()
        {
            XmlTextWriter writer = new XmlTextWriter(DATA_ROOT + fileName, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteStartElement("catalog");
            
            foreach (Product p in products)
            {
                writer.WriteStartElement("product");

                writer.WriteAttributeString("id", p.Id.ToString());
                writer.WriteAttributeString("category", p.Category);
                writer.WriteAttributeString("name", p.Name);
                writer.WriteAttributeString("vendor", p.Vendor);
                writer.WriteAttributeString("price", p.Price.ToString());
                writer.WriteAttributeString("quantity", p.Quantity.ToString());

                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            writer.Close();
        }

        public override string ToString()
        {
            string str = "";
            foreach (Product p in products)
            {
                str += p.ToString() + "\n";
            }
            return str;
        }

        public void ConsoleWrite()
        {
            Console.Write("+------------------------------------------------------------------------------+");
            Console.Write("| {0,2} | {1,-20} | {2,-15} | {3,-10} | {4,-6} | {5,-3} |",
                "ID", "CATEGORY", "NAME", "VENDOR", "PRICE", "QUANTITY"
            );
            Console.Write("+------------------------------------------------------------------------------+");
            Console.Write(this.ToString());
            Console.WriteLine("+-----------------------------------------------------------------------------+");
        }
    }
}
