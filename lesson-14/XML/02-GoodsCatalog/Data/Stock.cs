using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GoodsCatalog.Data
{
    class Stock
    {
        List<Product> products;

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public void EditProduct(Product p)
        {
            
        }
    }
}
