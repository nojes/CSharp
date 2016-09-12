using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_TestingSystem
{
    public abstract class EntityBase
    {
        protected uint id;

        public override string ToString()
        {
            return String.Format(" {0},", id);
        }

        public virtual void ConsoleWrite()
        {
            Console.WriteLine(this.ToString());
        }
    }
}