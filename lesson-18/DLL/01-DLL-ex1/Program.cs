using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace _01_DLL_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Group g1 = new Group("9PV5");
            g1.ConsoleWrite();

            Group g2 = new Group("10PV5", new Student[] {
                new Student("Vasya", "Pupkin", 21),
                new Student("Kolya", "Pupkin", 30),
                new Student("Sveta", "Pupkina", 18)
            });
            g2.ConsoleWrite();
        }
    }
}
