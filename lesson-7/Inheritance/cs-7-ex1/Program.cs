using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_7_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Vasya", 25);
            h1.ConsoleWrite();
            h1.Name = "Vasyok";
            h1.ConsoleWrite();
            
            Student s1 = new Student("Kolya", 30, 5);
            s1.ConsoleWrite();
            s1.Rate = 10;
            s1.Name = "Kolyan";
            s1.ConsoleWrite();
        }
    }
}
