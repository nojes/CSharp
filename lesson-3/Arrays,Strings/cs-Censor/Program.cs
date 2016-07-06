using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cs_Censor
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\Data\";
            string input_name = "input.txt";
            string output_name = "output.txt";

            string[] ban_words = new string[] {
                "петрушка",
                "сосиска",
                "редиска"
            };

            string[] replace_words = new string[] {
                "п***шка",
                "с***ка",
                "****cка"
            };

            FileStream input = new FileStream(path + input_name, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(input);
            string input_text = sr.ReadToEnd();
            sr.Close();
            input.Close();

            string output_text = input_text.Replace(ban_words[0], replace_words[0]);
            output_text = output_text.Replace(ban_words[1], replace_words[1]);
            output_text = output_text.Replace(ban_words[2], replace_words[2]);

            FileStream output = new FileStream(path + output_name, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(output);
            sw.Write(output_text);
            sw.Close();

            Console.WriteLine("\n Input > \n {0}", input_text);
            Console.WriteLine("\n Output > \n {0}", output_text);

            Console.ReadLine();
        }
    }
}
