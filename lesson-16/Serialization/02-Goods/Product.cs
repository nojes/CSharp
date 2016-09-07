using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Goods
{
    [Serializable]
    class Product
    {
        static uint staticId = 0;

        DateTime createdAt;

        public uint Id { get; set; }
        public string Waybill { get; set; }
        public string Title { get; set; }
       
        public uint Quantity { get; set; }

        public DateTime CreatedAt
        {
            get
            {
                return createdAt;
            }

            set
            {
                createdAt = value;
            }
        }

        public Product()
        {
            // ...
        }

        public Product(uint id, string waybill, string title, DateTime date, uint quantity)
        {
            this.Id = id;
            this.Waybill = waybill;
            this.Title = title;
            this.CreatedAt = date;
            this.Quantity = quantity;
        }

        public Product(string waybill, string title, DateTime date, uint quantity)
        {
            this.Id = ++staticId;
            this.Waybill = waybill;
            this.Title = title;
            this.CreatedAt = date;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return String.Format("| {0,2} | {1,-5} | {2,-5} | {3,-5} | {4,-5} |",
                Id, Waybill, Title, CreatedAt.ToString(), Quantity
            );
        }

        public void ConsoleWrite()
        {
            Console.WriteLine(this.ToString());
        }
        
    }
}
