using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ex1
{
    [Serializable]
    class Student
    {
        static uint staticId = 0;

        public uint Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public uint Age { get; set; }

        public Student(string fname, string lname, uint age)
        {
            this.Id = ++staticId;
            this.Fname = fname;
            this.Lname = lname;
            this.Age = age;
        }

        public Student(uint id, string fname, string lname, uint age)
        {
            this.Id = id;
            this.Fname = fname;
            this.Lname = lname;
            this.Age = age;
        }

        public override string ToString()
        {
            return String.Format(" {0} {1,-10} {2,-10} {3}", Id, Fname, Lname, Age);
        }

        public virtual void ConsoleWrite()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
