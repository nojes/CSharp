using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DATA_ROOT = "../../Data/";

            Student s1 = new Student("Vasya", "Student", 21);
            s1.ConsoleWrite();

            FileStream fs = new FileStream(DATA_ROOT + "student.dat", FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, s1);
            fs.Close();

            FileStream fs2 = new FileStream(DATA_ROOT + "student.dat", FileMode.Open, FileAccess.Read, FileShare.None);
            Student s2 = (Student)bf.Deserialize(fs2);
            fs2.Close();

            s2.ConsoleWrite();
        }
    }
}
