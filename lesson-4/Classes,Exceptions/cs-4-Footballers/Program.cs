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
                            // TODO: REFACTORING.

                            int[] heights = new int[30];
                            string[] sHeights;

                            if (!File.Exists(data_path + file_name)) // Create new file
                            {
                                // generate rand heights
                                Random r = new Random();
                                string heights_data = "";
                                for (uint i = 0; i < heights.Length; i++) {
                                    heights[i] = r.Next(160, 200);
                                }

                                // convert rand heights to string
                                heights_data += Convert.ToString(heights[0]);
                                for (uint i = 1; i < heights.Length; i++) {
                                    heights_data += " " + Convert.ToString(heights[i]);
                                }

                                // write to file
                                FileManager output = new FileManager(data_path, file_name);
                                output.Write(heights_data);

                                // display file data
                                Console.WriteLine(output.toString());
                            }
                            else // Parse file data
                            {
                                // read data from file
                                FileManager input = new FileManager(data_path, file_name);
                                input.Read();

                                // display file data
                                Console.WriteLine(input.toString());
                                
                                // parse heights
                                sHeights = input.Data.Split(' ');

                                // convert heights to string
                                for (uint i = 0; i < sHeights.Length; i++) {
                                    heights[i] = Convert.ToInt32(sHeights[i]);
                                }

                                double avg = heights.Average();
                                Console.WriteLine("\n Average: {0}", avg);
                            }
                            break;
                        }
                        

                }
            } while(!d.isExit());
            d.Exit();
        }
    }
}
