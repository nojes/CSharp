using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_12_ex1
{
    public enum ZodiacName
    {
        Aries,
        Taurus,
        Gemini,
        Cancer,
        Leo,
        Virgo,
        Libra,
        Scorpio,
        Ophiuchus,
        Sagittarius,
        Capricorn,
        Aquarius,
        Pisces
    }

    class Zodiac
    {
        ZodiacName name;
        DateTime begin_date;
        DateTime end_date;

        public Zodiac(ZodiacName name, DateTime begin_date, DateTime end_date)
        {
            this.name = name;
            this.begin_date = begin_date;
            this.end_date = end_date;
        }

        public override string ToString()
        {
            return String.Format(
                "{0} ({1} - {2})", 
                Enum.GetName(typeof(ZodiacName), name),
                begin_date.ToShortDateString(),
                end_date.ToShortDateString()
            );
        }

        public void ConsoleWrite()
        {
            Console.WriteLine(ToString());
        }
    }
}
