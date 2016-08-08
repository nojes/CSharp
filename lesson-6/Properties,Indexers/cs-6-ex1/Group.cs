using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_6_ex1
{
    class Group
    {
        Student[] students;

        public Group()
        {
            students = null;
        }

        public bool isEmpty()
        {
            return (students == null);
        }

        public void addStudent(Student s)
        {
            if (!isEmpty()) {
                int size = students.Length;
                Array.Resize(ref students, size + 1);
                students[size] = s;
            }
            else {
                students = new Student[1];
                students[0] = s;
            }
        }

        public override string ToString()
        {
            String str = "";
            if (!isEmpty()) {
                foreach (Student s in students)
                {
                    str += s.ToString();
                }
            }
            else {
                str = "\n Group is empty.";
            }

            return str;
        }
    }
}
