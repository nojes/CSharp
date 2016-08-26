using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_12_ex1
{
    class Person
    {
        string fname;
        string lname;
        DateTime birth;
        Zodiac zodiac;

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public DateTime Birth
        {
            get { return birth; }
            set { birth = value; }
        }

        public Person(string fname, string lname, DateTime birth, Zodiac zodiac)
        {
            this.fname = fname;
            this.lname = lname;
            this.birth = birth;
            this.zodiac = zodiac;
        }

        public bool isLName(string lname)
        {
            return (this.lname == lname);
        }

        public override string ToString()
        {
            return String.Format(
                "\n Firstname: {0} \n Lastname: {1} \n Birth date: {2} \n Zodiac: {3}", 
                fname, 
                lname,
                birth.ToLongDateString(), 
                zodiac
            );
        }

        public virtual void ConsoleWrite()
        {
            Console.WriteLine(ToString());
        }
    }
}
