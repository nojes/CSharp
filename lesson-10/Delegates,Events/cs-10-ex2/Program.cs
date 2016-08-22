using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_10_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            EventManager e = new EventManager();

            User u1 = new User("Vasya", "Pupkin", 21);
            u1.ConsoleWrite();

            e.MyEvent += u1.Handler;
            e.OnEvent();
        }
    }
}
