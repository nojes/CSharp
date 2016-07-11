using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nojes.Managers;
using System.IO;

namespace cs_4_Footballers
{
    class Program
    {
        static string data_path = @"../../Data/";
        static string file_name = "Footballers.txt";

        static void Main(string[] args)
        {
            Dialog d = new Dialog("Statistics Of Footballers Height", new string[] {
                "Exit",
                "Display statistics"
            });

            do
            {
                d.Welcome();
                d.InputChoise();
                switch (d.Choise)
                {
                    case 1:
                        {
                            break;
                        }
                        

                }
            } while(!d.isExit());
            d.Exit();
        }
    }
}
