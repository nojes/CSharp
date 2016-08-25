using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace cs_11_ex3
{
	class Program
	{
		static void Main(string[] args)
		{
			/** STACK */
			Stack s = new Stack(new int[] {
				10, 20, 30, 40, 50
			});

			foreach (int item in s)
				Console.WriteLine(" {0}", item);

			Console.WriteLine("Count: {0}", s.Count);
			Console.WriteLine("Pop: {0}", s.Pop());
			Console.WriteLine("Count: {0}", s.Count);

			/** QUEUE */
			Queue q = new Queue(new int[] {
				10, 20, 30, 40, 50
			});

			foreach (int item in q)
				Console.WriteLine(" {0}", item);
		
			q.Enqueue(100);
			Console.WriteLine();

			foreach (int item in q)
				Console.WriteLine(" {0}", item);

			/** SORTED LIST */
			SortedList sl = new SortedList();
			sl.Add(20, "lya-lya");
			sl.Add(10, "yo yo yo");
			sl.Add(15, "ku-ku");
			

			Console.WriteLine("\nKeys");
			foreach (var v in sl.GetKeyList()) {
				Console.WriteLine(" {0}", v);
			}

			Console.WriteLine("\nValues");
			foreach (var v in sl.GetValueList()) {
				Console.WriteLine(" {0}", v);
			}

			Console.WriteLine("\nKeys & Values");
			for (int i = 0; i < sl.Count; i++) {
				Console.WriteLine(" {0} => {1}", sl.GetKey(i), sl.GetByIndex(i));
			}

		}
	}
}
