using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;

namespace cs_11_ex1
{
    class Program
    {
        static ArrayList list = new ArrayList();

        static void Main(string[] args)
        {
            list.Add(100);
            DisplayList();

            list.Add(200);
            DisplayList();

            list.AddRange(new int[]{ 300, 400, 500 });
            DisplayList();

            list.AddRange(new int[]{ 1, 2, 3, 4, 5 });
            DisplayList();

            list.TrimToSize();
            DisplayList();
        }

        static void DisplayList()
        {
            Console.WriteLine("\t {0} Capacity => {1}", list.GetType().Name, list.Capacity);
            Console.WriteLine("\t Capacity => {0}", list.Capacity);
            Console.WriteLine("\t Count => {0} \n ", list.Count);
        }
    }
}
