using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_3_ex2
{
    class Program
    {
        static void coutMessage(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n[INFO]: {0} > ", msg);
            Console.ResetColor();
        }

        static void coutString(string msg, string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n {0} =>", msg);
            Console.ResetColor();
            Console.Write(" {0} \n", s);
        }

        static void Main(string[] args)
        {
            // String
            string s = "Hello, Vasya Pupkin";
            coutString("String", s);

            // length
            coutMessage("String length");
            Console.WriteLine(s.Length);

            // symbols
            coutMessage("First symbol");
            Console.WriteLine(s[0]);
            coutMessage("Last symbol");
            Console.WriteLine(s[s.Length - 1]);

            // comparison
            string a = "String a";
            string b = "String b";
            coutString("a", a);
            coutString("b", b);

            coutMessage("String comparison");
            Console.WriteLine(a == b);
            coutMessage("String.Compare");
            Console.WriteLine(String.Compare(a, b));


            string info = "Some info string. Second some info string.";
            coutString("info", info);

            // index
            coutMessage("info: Index of \".\"");
            int index = info.IndexOf(".");
            Console.WriteLine(index);

            // substr
            coutMessage("info: substr");
            Console.WriteLine(info.Substring(index + 2));

            // split
            string[] news = info.Split('.');
            coutMessage("info: Split");
            foreach(string str in news)
            {
                Console.WriteLine(str.Trim());
            }

            // replace
            string s1 = "111 xxx 111 xxx";
            string s2 = s1.Replace("111", "222");
            coutString("s1", s1);
            coutMessage("replace");
            coutString("s2", s2);


            Console.ReadLine();
        }
    }
}
