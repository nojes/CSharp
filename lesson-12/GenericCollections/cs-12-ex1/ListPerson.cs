using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_12_ex1
{
    class ListPerson
    {
        List<Person> persons;
        List<Zodiac> zodiacs;

        public ListPerson()
        {
            persons = new List<Person>();
            zodiacs = new List<Zodiac>();
        }

        public void AddPerson(Person p)
        {
            persons.Add(p);
        }

        public void DelPerson(Person p)
        {
            persons.Remove(p);
        }

        public Person GetPerson(string lname)
        {
            foreach (Person p in persons) {
                if (p.isLName(lname)) {
                    return p;
                }
            }
            return null;
        }

        //public void GetZodiac()
        //{

        //}

        //public static operator+()
        //{

        //}

        //public static operator-()
        //{

        //}

        //public static operator*()
        //{

        //}

        public override string ToString()
        {
            string str = "";
            foreach(Person p in persons) {
                str += p.ToString() + "\n";
            }
            return str;
        }

        public virtual void ConsoleWrite()
        {
            Console.WriteLine(ToString());
        }
    }
}
