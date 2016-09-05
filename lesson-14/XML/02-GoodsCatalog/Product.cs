using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GoodsCatalog
{
    class Product
    {
        uint id;
        string category;
        string name;
        string vendor;
        double price;
        uint quantity;

        public uint Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string Vendor
        {
            get
            {
                return vendor;
            }

            set
            {
                vendor = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
        public uint Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public Product()
        {
            // ...
        }

        public Product(uint id, string category, string name, string vendor, double price, uint quantity)
        {
            this.Id = id;
            this.Category = category;
            this.Name = name;
            this.Vendor = vendor;
            this.Price = price;
            this.Quantity = quantity;
        }

        public Product(string category, string name, string vendor, double price, uint quantity)
        {
            this.Category = category;
            this.Name = name;
            this.Vendor = vendor;
            this.Price = price;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return String.Format("| {0,2} | {1,-20} | {2,-15} | {3,-10} | {4,-6} | {5,-8}|", 
                Id, Category, Name, Vendor, Price, Quantity
            );
        }

        public void ConsoleWrite()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
