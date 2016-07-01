using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_1_QE
{
    class DialogManager
    {
        int choise;
        string ans;
        string prefix = "\n [INFO]: ";

        public int Choise
        {
            get { return choise; }
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("\t Программа решения квадраиных уравнений.");
        }

        public void Stop()
        {
            Console.WriteLine("\n [INFO]: Программа завершена.");
        }

        public void DisplayMenu()
        {
            
            Console.WriteLine(" <1> - Решить новое уравнение.");
            Console.WriteLine(" <2> - Показать журнал вычислений.");
            Console.WriteLine(" <3> - Выйти из программы.");
            Console.Write("  -> ");
            try
            {
                choise = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n [ERROR]: {0}", err.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        public bool AllowContinue()
        {
            Console.Write(prefix + "Продолжать? (y/n)");
            Console.Write("  -> ");

            ans = Console.ReadLine();
            return (ans == "y");
        }
    }
}
