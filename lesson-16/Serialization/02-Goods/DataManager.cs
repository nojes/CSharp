using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _02_Goods
{
    class DataManager
    {
        const string DATA_ROOT = "../../Data/";
        string fileName = "goods.dat";

        List<Product> products;

        public DataManager()
        {
            products = new List<Product>();
        }

        internal List<Product> Products
        {
            get
            {
                return products;
            }

            set
            {
                products = value;
            }
        }

        public void Load()
        {
            if (!File.Exists(DATA_ROOT + fileName)) {
                FileStream fs = new FileStream(DATA_ROOT + fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                fs.Close();
            }
            else {
                FileStream fs = new FileStream(DATA_ROOT + fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                BinaryFormatter bf = new BinaryFormatter();
                Products = (List<Product>)bf.Deserialize(fs);
                fs.Close();
            }
            
        }

        public void Upload(List<Product> products)
        {
            FileStream fs = new FileStream(DATA_ROOT + fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, products);
            fs.Close();
        }
    }
}
