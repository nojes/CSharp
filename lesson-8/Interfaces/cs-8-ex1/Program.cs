using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_8_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lorry l = new Lorry("Kamaz", 12, 5000, 10000);
            Console.WriteLine(l.ToString());
            l.Mark = "KAMAZ";
            l.Capacity = 20000;
            Console.WriteLine(l.ToString());
        }
    }
}
