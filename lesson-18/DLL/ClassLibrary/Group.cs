using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Group
    {
        static uint staticId = 0;

        public uint Id { get; set; }
        public string Name { get; set; }
        List<Student> students = new List<Student>();

        public Group(string name)
        {
            this.Id = ++staticId;
            this.Name = name;
        }

        public Group(string name, Student[] students)
        {
            this.Id = ++staticId;
            this.Name = name;
            foreach (Student s in students) {
                this.students.Add(s);
            }
        }

        public Group(uint id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            string str = String.Format("\n Group: {0} {1} \n", Id, Name);

            if (students.Count != 0) {
                foreach (Student s in students) {
                    str += "\t" + s.ToString() + "\r\n";
                }
            }
            else {
                str += "\tGroup is empty.";
            }

            return str;
        }

        public virtual void ConsoleWrite()
        {
            Console.WriteLine(this.ToString());
        }

        public void addStudent(Student s)
        {
            this.students.Add(s);
        }

        public void removeStudent(Student s)
        {
            this.students.Remove(s);
        }
    }
}
