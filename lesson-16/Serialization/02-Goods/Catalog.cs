using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Goods
{
    class Catalog
    {
        static uint productId = 0;

        List<Product> products;

        public List<Product> Products
        {
            get { return products; } 
            set { products = value; }
        }

        public Catalog()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product p)
        {
            p.Id = ++productId;
            Products.Add(p);
        }

        public void EditProduct(Product p)
        {
            // ...
        }

        public override string ToString()
        {
            string str = "";
            foreach (Product p in Products)
            {
                str += p.ToString() + "\n";
            }
            return str;
        }

        public void ConsoleWrite()
        {
            Console.Write("+------------------------------------------------------------------------------+");
            Console.WriteLine("| {0,2} | {1,-5} | {2,-5} | {3,-5} | {4,-5} |",
               "ID", "WAYBILL", "TITLE", "DATE", "QUANTITY"
            );
            Console.Write("+------------------------------------------------------------------------------+");
            Console.Write(this.ToString());
            Console.WriteLine("+-----------------------------------------------------------------------------+");
        }
    }
}
