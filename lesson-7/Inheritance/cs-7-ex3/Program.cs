using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_7_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[] {
                new Fish("Crucian"),
                new Bird("Gull"),
                new Frog("Toad")
            };

            foreach (Animal animal in animals)
            {
                Console.Write('\n' + animal.ToString());
                animal.Breathe();
            }
        }
    }
}
