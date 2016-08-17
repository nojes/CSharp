using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_9_ex2
{
    public enum Days {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = Enum.GetNames(typeof(Days));
            var values = Enum.GetValues(typeof(Days));

            foreach (var v in values)
            {
                Console.WriteLine(String.Format(" {0}", v));
            }


            Console.Write("\n Enter number of day of the week \n > ");
            int day = Convert.ToInt32(Console.ReadLine());

            //string[] sDays = new string[] {
            //    "",
            //    "",
            //    "",
            //    ""
            //};

            Days days = (Days)day;

            string res = "";

            switch(days)
            {
                case Days.Monday:       
                    res = "Понедельник"; 
                    break;
                case Days.Tuesday:      
                    res = "Вторник";
                    break;
                case Days.Wednesday:    
                    res = "Среда";
                    break;
                case Days.Thursday:     
                    res = "Четверг";
                    break;
                case Days.Friday:       
                    res = "Пятница";
                    break;
                case Days.Saturday:     
                    res = "Суббота";
                    break;
                case Days.Sunday:       
                    res = "Воскресенье";
                    break;
            }

            Console.WriteLine(" Your day of the week: {0}", res);
            Console.ReadLine();
        }
    }
}
