using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cs_13_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PATH = "D:/temp";

            // Create
            DirectoryInfo dir = new DirectoryInfo(PATH);
            if(dir.Exists) {

                DirectoryInfo subDir1 = dir.CreateSubdirectory("subDir1");
                DirectoryInfo subDir2 = dir.CreateSubdirectory("subDir2");
                subDir2.CreateSubdirectory("subSubDir");
                Console.WriteLine("[INFO]: New subdirectory successfuly created!");

                // Delete
                DirectoryInfo dir2 = new DirectoryInfo(PATH + "/subDir1");
                dir2.Delete();

                // Recursive delete
                subDir2.Delete(true);

            } else {

                string ans = "";
                Console.WriteLine("[ERROR]: Parent directory does not exist.");
                Console.WriteLine(": Create directory? (y/n)");
                ans = Convert.ToString(Console.ReadLine());
                if(ans == "y") {
                    dir.Create();
                }

            }

            // Date, time
            DateTime cr = dir.CreationTime;
            DateTime lat = dir.LastAccessTime;
            DateTime lwt = dir.LastWriteTime;
            string path = dir.FullName;
            string rootPath = dir.Root.ToString();
            string name = dir.Name;

            Console.WriteLine(" CreationTime: {0}", cr);
            Console.WriteLine(" LastAccessTime: {0}", lat);
            Console.WriteLine(" LastWriteTime: {0}", lwt);
            Console.WriteLine(" FullName: {0}", path);
            Console.WriteLine(" Root: {0}", rootPath);
            Console.WriteLine(" Name: {0}", name);

            // Directories and files
            DirectoryInfo CSharpDir = new DirectoryInfo(PATH + "/CSharp");
            DirectoryInfo[] subDirs = CSharpDir.GetDirectories();
            Console.WriteLine("\nGetDirectories: ");
            foreach (DirectoryInfo d in subDirs) {
                Console.WriteLine(" {0}", d.Name);
            }

            FileInfo[] subFiles = CSharpDir.GetFiles();
            Console.WriteLine("\nGetFiles: ");
            foreach (FileInfo f in subFiles) {
                Console.WriteLine(" {0}", f.Name);
            }
        }
    }
}
