using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace cs_10_ex2
{
    class User
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


        public User(string firstname, string lastname, uint age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public override string ToString()
        {
            return String.Format(" Firstname: {0} \n Lastname: {1} \n Age: {2}", firstname, lastname, age);
        }

        public void ConsoleWrite()
        {
            Console.WriteLine(this.ToString());
        }


        public void Handler()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n {0} is work ", MethodBase.GetCurrentMethod().Name);
            Console.ResetColor();
        }
    }
}
