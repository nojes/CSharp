using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_6_ex1
{
    class Student
    {
        string name;
        int age;
        double rate;

        public string Name 
        { 
            get { return name; } set { name = value; } 
        }

        public int Age 
        { 
            get { return age; } set { age = value; } 
        }

        public double Rate 
        { 
            get { return rate; } set { rate = value; } 
        }

        public Student()
        {
            name = "";
            age = 0;
            rate = 0.0;
        }

        public Student(string name, int age, double rate)
        {
            this.name = name;
            this.age = age;
            this.rate = rate;
        }

        public override string ToString()
        {
            return String.Format("\n Name: {0} \n Age: {1} \n Rate: {2}", name, age, rate);
        }
    }
}
