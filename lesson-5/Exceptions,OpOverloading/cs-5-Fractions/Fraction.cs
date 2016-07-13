﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_5_Fractions
{
    public class Fraction
    {
        private int x;
        private int y;

        public Fraction(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.x * b.x, a.y * b.y);
        }

        public string toString()
        {
            return String.Format("{0} / {1}", x, y);
        }
    }
}
