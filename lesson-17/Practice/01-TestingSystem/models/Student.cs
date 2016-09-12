using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_TestingSystem
{
    public class Student : EntityBase
    {
        string fname;
        string lname;
        uint age;

        public override string ToString()
        {
            return base.ToString() + String.Format(" {0}, {1}, {2}", fname, lname, age);
        }
    }
}