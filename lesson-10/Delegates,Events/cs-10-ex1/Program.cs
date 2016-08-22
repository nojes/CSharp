using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace cs_10_ex1
{
    class Program
    {
        static public int end = 50;

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Run1));
            Thread t2 = new Thread(new ThreadStart(Run2));

            t1.Start();
            t2.Start();

            for (int i = 0; i < end; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(String.Format(" {0}", i + 1));
                Thread.Sleep(500);
            }
        }

        static void Run1()
        {
            for (int i = 0; i < end; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(String.Format("\t {0}", i + 1));
                Thread.Sleep(600);
            }
        }

        static void Run2()
        {
            for (int i = 0; i < end; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(String.Format("\t\t {0}", i + 1));
                Thread.Sleep(650);
            }
        }
    }
}