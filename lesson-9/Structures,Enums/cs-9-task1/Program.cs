using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_9_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Article a1 = new Article("Article title 1", 100, ArticleType.Computers);
            Article a2 = new Article("Article title 2", 200, ArticleType.Smartphones);

            Console.WriteLine(a1.ToString());
            Console.WriteLine(a2.ToString());
        }
    }
}
