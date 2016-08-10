using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_7_ex1
{
    public class Human
    {
        protected string name;
        protected uint age;

        public Human(string name, uint age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name 
        {
            get { return name; }
            set { name = value;}
        }

        public uint Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return String.Format("\n Name: {0} \n Age: {1}", name, age);
        }

        public void ConsoleWrite()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
