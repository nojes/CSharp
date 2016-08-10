using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_7_task1
{
    public class Rectangle : Shape
    {
        double a;
        double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double calcP()
        {
            return (a + b) * 2;
        }

        public override double calcS()
        {
            return a * b;
        }
    }
}
