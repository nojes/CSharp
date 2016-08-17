using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_9_ex1
{
    public struct Data
    {
        public int a;
        public long b;
        public double c;
        public string d;
        public bool e;

        public Data(int a, long b, double c, string d, bool e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
        }

        public void Display()
        {
            Console.Write(String.Format(" a: {0} \n b: {1} \n c: {2} \n d: {3} \n e: {4} \n", a, b, c, d, e));
        }
    }
}
