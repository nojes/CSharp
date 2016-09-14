using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student
    {
        static uint staticId = 0;

        public uint Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public uint Age { get; set; }

        public Student(string first_name, string last_name, uint age)
        {
            this.Id = ++staticId;
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Age = age;
        }

        public Student(uint id, string first_name, string last_name, uint age)
        {
            this.Id = id;
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Age = age;
        }

        public override string ToString()
        {
            return String.Format("{0} {1,-10} {2,-10} {3}", Id, First_name, Last_name, Age);
        }

        public virtual void ConsoleWrite()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
