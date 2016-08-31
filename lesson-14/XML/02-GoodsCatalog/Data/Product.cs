using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GoodsCatalog.Data
{
    class Product
    {
        static uint productId = 0;

        uint id;
        string category;
        string name;
        string vendor;
        double price;
        uint quantity;

        public Product(string category, string name, string vendor, double price, uint quantity)
        {
            this.id = ++productId;
            this.category = category;
            this.name = name;
            this.vendor = vendor;
            this.price = price;
            this.quantity = quantity;
        }
        
    }
}
