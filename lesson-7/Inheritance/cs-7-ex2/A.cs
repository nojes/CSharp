using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_7_ex2
{
    class A
    {
        protected int x;

        public A(int x)
        {
            this.x = x;
        }

        public override string ToString()
        {
            return String.Format("\n X: {0}", x);
        }

        public virtual int Calc()
        {
            return x * 2;
        }
    }
}
