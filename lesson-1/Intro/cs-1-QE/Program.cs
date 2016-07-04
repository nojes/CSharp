using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_1_QE
{
    class Program
    {
        static void Main(string[] args)
        {
            DialogManager dm = new DialogManager();
            CalcManager cm = new CalcManager();

            do
            {
                dm.Welcome();
                dm.DisplayMenu();

                switch (dm.Choise)
                {
                    case 1:
                        if(cm.Input()) {
                            cm.Calc();
                            cm.Display();
                        }
                        break;

                    case 2:
                        cm.CalcLog();
                        break;

                    case 3:
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" [ERROR]: Ошибка ввода.");
                        break;
                }
            } while (dm.Choise != 3 && dm.AllowContinue());
            dm.Stop();
        }
    }
}
