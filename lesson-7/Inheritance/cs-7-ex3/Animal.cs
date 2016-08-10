using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_7_ex3
{
    class Animal
    {
        protected string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}", name);
        }

        public virtual void Breathe()
        {
            Console.WriteLine();
            Console.Write("Breathe with ");
        }
    }
}
