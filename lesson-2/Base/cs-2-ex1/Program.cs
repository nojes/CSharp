using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_2_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            do {
                CheckTriangle();
            } while (true);
            
        }

        static void CheckTriangle()
        {
            double a, b, c;

            try
            {
                Console.Write(" a -> ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write(" b -> ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write(" c -> ");
                c = Convert.ToDouble(Console.ReadLine());

                if (a < (b + c) && b < (b + c) && c < (a + b))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("[INFO]: It's triangle. \n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[INFO]: It's not triangle. \n");
                }
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR]: {0} \n", err.Message);
            }
            Console.ResetColor();
        }
    }
}
