using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_1_QE
{
    class CalcManager
    {
        double a, b, c;
        double D;
        double x, x1, x2;

        enum Solution {
            NOT_HAVE,
            ONE_ROOT,
            TWO_ROOTS
        }
        Solution s;

        string[] res_messages = {
            "Дискриминант меньше нуля => уравнение не имеет действительных решений.",
            "Дискриминант равен нулю => уравнение имеет один действительный корень:",
            "Дискриминант больше нуля => уравнение имеет два действительных корня:"
        };

        public bool Input()
        {
            Console.WriteLine(" Введите коэффициенты уравнения: ");
            try
            {
                Console.Write(" a -> ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write(" b -> ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.Write(" c -> ");
                c = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" [ERROR]: {0}", err);
                return false;
            }
            return true;
        }

        public void Calc()
        {
            if (a != 0)
            {
                D = (b * b) - (4 * a * c);

                if (D > 0)
                {
                    D = Math.Sqrt(D);
                    x1 = (-b - Math.Sqrt(D)) / 2 / a;
                    x2 = (-b + Math.Sqrt(D)) / 2 / a;

                    s = Solution.TWO_ROOTS;
                }
                else if (D == 0)
                {
                    x = -b / 2 / a;
                    s = Solution.ONE_ROOT;
                }
                else
                {
                    s = Solution.NOT_HAVE;
                }
            }
            else
            {
                x = -c / b;
                s = Solution.ONE_ROOT;
            }
        }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine(" [RESULT]: D = {0}", D);

            switch (s)
            {
                case Solution.NOT_HAVE:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" [RESULT]: {0} \n", res_messages[(int)Solution.NOT_HAVE]);
                    break;

                case Solution.ONE_ROOT:
                    Console.WriteLine(" [RESULT]: {0} \n", res_messages[(int)Solution.ONE_ROOT]);
                    Console.WriteLine(" [RESULT]: x = {0}", x);
                    break;

                case Solution.TWO_ROOTS:
                    Console.WriteLine(" [RESULT]: {0} \n", res_messages[(int)Solution.TWO_ROOTS]);
                    Console.WriteLine(" [RESULT]: x1 = {0}", x1);
                    Console.WriteLine(" [RESULT]: x2 = {0}", x2);
                    break;
            }
        }

        public void CalcLog()
        {
            Console.WriteLine(" [INFO]: It's in develop.");
        }
    }
}
