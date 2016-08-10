using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_7_ex2
{
    class B : A
    {
        double y;

        public B(int x, double y) : base(x)
        {
            this.y = y;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("\n Y: {0}", y);
        }

        public double SquareSum()
        {
            return (x * 2) + (y * 2);
        }

        public override int Calc()
        {
            return (x * 3);
        }
    }
}
