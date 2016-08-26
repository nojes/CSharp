using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nojes.Managers;

namespace cs_12_ex1
{
    class Program
    {
        public enum MainMenu
        {
            Exit,
            DisplayPersons,
            AddPerson,
            RemovePerson,
            FindPerson
        }

        static void Main(string[] args)
        {
            Zodiac[] zodiacs = {
                new Zodiac(ZodiacName.Aquarius, new DateTime(2005, 1, 1), new DateTime(2006, 3, 1)),
                new Zodiac(ZodiacName.Aries, new DateTime(2005, 2, 1), new DateTime(2006, 2, 1))
            };

            Person p = new Person(
                "Vasya", 
                "Pupkin", 
                new DateTime(1985, 3, 1),
                zodiacs[0]
            );
            
            //p.ConsoleWrite();

            ListPerson list = new ListPerson();
            list.AddPerson(p);
            list.AddPerson(new Person(
                "Kolya",
                "Pupkin",
                new DateTime(1970, 10, 14),
                zodiacs[1])
            );

            DialogManager m = new DialogManager("List of Persons", new string[] { 
                "Display Persons",
                "Add Person",
                "Remove Person",
                "Find Person"
            });
            
            
            do
            {
                m.Welcome();
                m.InputChoise();

                switch(m.Choise)
                {
                    case 1:
                        list.ConsoleWrite();
                        break;

                    case 2:
                        {
                            string fname;
                            string lname;
                            DateTime birth;
                            Zodiac zodiac = zodiacs[0]; // TODO

                            Console.Write(" Firstname > ");
                            fname = Console.ReadLine();
                            Console.Write(" Lastname > ");
                            lname = Console.ReadLine();
                            Console.Write(" Birth date > ");
                            birth = Convert.ToDateTime(Console.ReadLine());

                            Person person = new Person(fname, lname, birth, zodiac);
                            list.AddPerson(person);

                            Console.WriteLine(" OK!");
                            break;
                        }
                    case 3:
                        break;

                    case 4:
                        break;

                    default:

                        break;
                }
            } while (!m.isExit());

            m.Exit();
        }
    }
}
