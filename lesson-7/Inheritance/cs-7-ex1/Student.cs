using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_7_ex1
{
    class Student : Human
    {
        float rate;

        public float Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public Student(string name, uint age, float rate)
            : base(name, age)
        {
            this.rate = rate;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("\n Rate: {0}", rate);
        }

        public void ConsoleWrite()
        {
            base.ConsoleWrite();
        }
    }
}
