using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_11_ex2
{
    class Student
    {
        string firstname;
        string lastname;
        uint age;


        string Firstname
        {
            get { return firstname; }
            set { this.firstname = value; }
        }

        string Lastname
        {
            get { return firstname; }
            set { this.firstname = value; }
        }

        string Age
        {
            get { return firstname; }
            set { this.firstname = value; }
        }


        public Student(string firstname, string lastname, uint age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public override string ToString()
        {
            return String.Format(" Firstname: {0} \n Lastname: {1} \n Age: {2} \n", firstname, lastname, age);
        }

        public void ConsoleWrite()
        {
            Console.WriteLine(this.ToString());
        }

        /*
        public static bool operator==(Student a, Student b)
        {
            if((a.firstname == b.firstname && 
                a.lastname == b.lastname &&
                a.age == b.age))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Student a, Student b)
        {
            if (!(a.firstname == b.firstname &&
                a.lastname == b.lastname &&
                a.age == b.age))
            {
                return true;
            }
            return false;
        }
        */
    }
}
