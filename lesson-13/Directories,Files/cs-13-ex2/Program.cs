using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cs_13_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ROOT = @"D:/temp/";

            // File info
            FileInfo f1 = new FileInfo(ROOT + "file1.txt");
            Console.WriteLine(" CreationTime: {0}", f1.CreationTime);
            Console.WriteLine(" LastAccessTime: {0}", f1.LastAccessTime);
            Console.WriteLine(" LastWriteTime: {0}", f1.LastWriteTime);
            Console.WriteLine(" Directory: {0}", f1.Directory);
            Console.WriteLine(" DirectoryName: {0}", f1.DirectoryName);
            Console.WriteLine(" Exists: {0}", f1.Exists);
            Console.WriteLine(" Extension: {0}", f1.Extension);
            Console.WriteLine(" FullName: {0}", f1.FullName);
            Console.WriteLine(" IsReadOnly: {0}", f1.IsReadOnly);
            Console.WriteLine(" Length: {0}", f1.Length);
            Console.WriteLine(" Name: {0}", f1.Name);

            // Create
            StreamWriter sw = f1.CreateText();
            // Write content
            sw.Write("Hello");
            sw.Close();

            // Append content
            StreamWriter sw2 = f1.AppendText();
            sw2.Write("\nGoodbye");
            sw2.Close();

            // Read content
            StreamReader sr = f1.OpenText();
            string content = sr.ReadToEnd();
            Console.WriteLine("\n file1.txt: \n{0}", content);
            sr.Close();

            // Copy
            FileInfo f2 = f1.CopyTo(ROOT + "file2.txt", true);

            // Move
            DirectoryInfo d = new DirectoryInfo(ROOT + "dir/");
            d.Create();
            f2.MoveTo(d.FullName + f2.Name);
        }
    }
}
