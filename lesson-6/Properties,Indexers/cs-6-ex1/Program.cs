using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_6_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Vasya";
            s1.Age = 21;
            s1.Rate = 10.7;
            Student s2 = new Student("Kolya", 23, 9.3);
            Student s3 = new Student("Sveta", 30, 8);

            Console.WriteLine(s1.ToString());

            Group g = new Group();
            g.addStudent(s1);
            g.addStudent(s2);
            g.addStudent(s3);
            Console.WriteLine(g.ToString());

            Console.WriteLine(g[2].ToString());
        }
    }
}
