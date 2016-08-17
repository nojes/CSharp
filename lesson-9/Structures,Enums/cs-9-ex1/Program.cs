using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_9_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Data a = new Data(7, 99789797, 555.12, "data", true);
            Data b = a;

            Display(a, b);

            b.a = 777;
            b.d = "dataaaaaaa";

            Display(a, b);
        }

        static void Display(Data a, Data b)
        {
            Console.WriteLine("\n Data a");
            a.Display();
            Console.WriteLine("\n Data b");
            b.Display();
        }
    }
}
