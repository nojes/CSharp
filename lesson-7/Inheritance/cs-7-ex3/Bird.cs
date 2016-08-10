using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_7_ex3
{
    class Bird : Animal
    {
        public Bird(string name)
            : base(name)
        {}

        public override void Breathe()
        {
            base.Breathe();
            Console.Write("lungs");
            Console.WriteLine();
        }
    }
}
