using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_3_ex1
{
    class Program
    {
        static void displayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" {0, 4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void displayArray(int[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(" [{0}] => {1}", i, array[i]);
            }
        }

        static void RandomizeArray(int[] array, int a, int b)
        {
            Random r = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = r.Next(a, b);
            }
        }

        static void displayMessage(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n[INFO]: {0} >", msg);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            // Matrix
            const int N = 3;
            const int M = 4;
            int[,] matrix = new int[N, M] {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
            displayMessage("Matrix");
            displayMatrix(matrix);

            // CopyTo
            int[] arr1 = new int[] {
                1, 2, 3, 4, 5
            };
            int[] arr2 = new int[7];
            arr1.CopyTo(arr2, 0);

            displayMessage("Array 1");
            displayArray(arr1);

            displayMessage("Array 1 copy to Array 2");
            displayArray(arr2);

            // Clear
            displayMessage("Cleared from 0 to 3");
            Array.Clear(arr1, 0, 3);
            displayArray(arr1);

            // IndexOf
            displayMessage("Index of 5");
            Console.WriteLine("index: {0}", Array.IndexOf(arr2, 5));

            // Resize
            Array.Resize(ref arr2, 10); // ref - link (&)
            displayMessage("Resize to 10");
            displayArray(arr2);

            // Sort
            int[] rand_arr = new int[10];
            displayMessage("Random array");
            RandomizeArray(rand_arr, 0, 100);
            displayArray(rand_arr);

            displayMessage("Sorted random array");
            Array.Sort(rand_arr);
            displayArray(rand_arr);

            // Min, Max, Sum, Avg
            displayMessage("Min value");
            Console.WriteLine(rand_arr.Min());

            displayMessage("Max value");
            Console.WriteLine(rand_arr.Max());

            displayMessage("Average value");
            Console.WriteLine(rand_arr.Average());

            displayMessage("Sum of values");
            Console.WriteLine(rand_arr.Sum());



            Console.ReadLine();
        }
    }
}
