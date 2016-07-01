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
            do
            {
                dm.Run();
                dm.DisplayMenu();
                switch (dm.Choise)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    default:
                        break;
                }
            } while (dm.AllowContinue());
            dm.Stop();
        }
    }
}
