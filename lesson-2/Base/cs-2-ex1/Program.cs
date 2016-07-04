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
                //CheckTriangle();
                //CheckSeason();
                //RandPrint();
                //PythagoreanTable();
                Array();
                Matrix();
                RaggedArray();
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

        static void CheckSeason()
        {
            int month;

            Console.Write(" Number of month -> ");
            try
            {
                month = Convert.ToInt32(Console.ReadLine());

                switch(month)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("[INFO]: It's Winter. \n");
                        break;

                    case 3:
                    case 4:
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("[INFO]: It's Spring. \n");
                        break;

                    case 6:
                    case 7:
                    case 8:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[INFO]: It's Summer. \n");
                        break;

                    case 9:
                    case 10:
                    case 11:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("[INFO]: It's Autumn. \n");
                        break;
                }
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR]: {0} \n", err.Message);
            }
            Console.ResetColor();
        }

        static void RandPrint()
        {
            Random r = new Random();
            
            int num;
            int quantity;

            Console.Write(" Put quantity -> ");
            try {
                quantity = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < quantity; i++)
                {
                    num = r.Next(0, 100);
                    Console.WriteLine("[{0}] => {1}", i, num);
                }
                Console.WriteLine();
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR]: {0} \n", err.Message);
            }
            Console.ResetColor();
        }

        static void PythagoreanTable()
        {
            Console.WriteLine("Press any key to print Pythagorean Table ...");
            Console.ReadLine();
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(" {0, 4}", (i * j));
                }
                Console.WriteLine("\n");
            }
        }

        static void Array()
        {
            Random r = new Random();

            int size = 0;
            int[] arr;

            Console.Write(" Put array size -> ");
            try
            {
                size = Convert.ToInt32(Console.ReadLine());

                arr = new int[size];

                for (int i = 0; i < size; i++) {
                    arr[i] = r.Next(0, 100);
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    RandConsoleColor();
                    Console.WriteLine(" [{0}] => {1}", i, arr[i]);
                }
                Console.WriteLine();
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR]: {0} \n", err.Message);
            }
            Console.ResetColor(); 
        }

        static void Matrix()
        {
            Random r = new Random();

            int n = 5;
            int m = 7;
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = r.Next(0, 99);
                }
            }

            Console.WriteLine("\t\tM A T R I X");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" {0, 4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void RandConsoleColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen + Rand(0, 14);
        }

        static int Rand(int a, int b)
        {
            Random r = new Random();
            return r.Next(a, b);
        }

        static void RaggedArray()
        {
            const int RAGGED_ARR_SIZE = 3;
            int[][] raged_array = new int[RAGGED_ARR_SIZE][];

            raged_array[0] = new int[] { 1, 2, 3 };
            raged_array[1] = new int[] { 4, 5, 6 };
            raged_array[2] = new int[] { 7, 8, 9 };

            Console.WriteLine("\n\t Ragged array");
            for (int i = 0; i < RAGGED_ARR_SIZE; i++)
            {
                foreach (int elem in raged_array[i])
                    Console.Write(" {0}", elem);
                Console.WriteLine("\n");
            }
        }
    }
}
