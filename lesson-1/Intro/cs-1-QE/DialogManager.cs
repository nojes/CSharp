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

        public int Choise
        {
            get { return choise; }
        }

        public void Welcome()
        {
            Console.Clear();
            Console.ResetColor();
            
            Console.WriteLine();
            Console.WriteLine("\t +----------------------------------------+");
            Console.WriteLine("\t | Программа решения квадратных уравнений |");
            Console.WriteLine("\t +----------------------------------------+");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
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
            finally
            {
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        public bool AllowContinue()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n Продолжать? (y/n)");
            Console.Write("  -> ");
            Console.ResetColor();
            ans = Console.ReadLine();
            return (ans == "y");
        }
    }
}
