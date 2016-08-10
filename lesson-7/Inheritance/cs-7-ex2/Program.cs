using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_7_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(2);
            Console.WriteLine(a.ToString());
            Console.WriteLine(" Calc: {0}", a.Calc());

            B b = new B(2, 4);
            Console.WriteLine(b.ToString());
            Console.WriteLine(" Calc: {0}", b.Calc());
        }
    }
}
