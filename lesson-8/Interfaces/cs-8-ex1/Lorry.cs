using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_8_ex1
{
    public class Lorry : Car
    {
        float capacity;

        public float Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public Lorry(string mark, int cylinders, float power, float capacity) : base(mark, cylinders, power)
        {
            this.capacity = capacity;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" \n Capacity: {0}", capacity);
        }
    }
}
