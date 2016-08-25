using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace cs_11_ex2
{
    class Program
    {
        static ArrayList students = new ArrayList(new Student[] {
                new Student("Vasya", "Pupkin", 21),
                new Student("Kolya", "Pupkin", 30),
                new Student("Sveta", "Pupkina", 18)
            });

        static void Main(string[] args)
        {
            DisplayStudents(students);

            ArrayList num_list = new ArrayList();
            num_list.AddRange(new int[] { 1, 2, 3, 4, 5 });
            foreach (int num in num_list) {
                Console.WriteLine(" {0}", num);
            }

            Console.WriteLine("Insert student: \n");
            students.Insert(2, new Student("Prosto","Petro", 25));
            DisplayStudents(students);

            Console.WriteLine("RemoveAt student: \n");
            students.RemoveAt(2);
            DisplayStudents(students);

            Student vasya = new Student("Vasya", "Removekin", 22);
            Console.WriteLine("Add student: \n");
            students.Add(vasya);
            DisplayStudents(students);

            Console.WriteLine("Remove student: \n");
            students.Remove(vasya);
            DisplayStudents(students);

			ArrayList students2 = students.GetRange(1, 2);
			DisplayStudents(students2);
		}

        static void DisplayStudents(ArrayList students)
        {
            foreach (Student s in students) {
                s.ConsoleWrite();
            }
        }
    }
}
