using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_9_task1
{
    public enum ArticleType: uint
    {
        undefined,
        Computers,
        Smartphones
    }

    public struct Article
    {
        static uint article_id = 0;
        public uint id;
        public string title;
        public double price;
        public ArticleType type;

        public Article(string title, double price, ArticleType type)
        {
            this.id = ++article_id;
            this.title = title;
            this.price = price;
            this.type = type;
        }

        public override string ToString()
        {
            string articles = Enum.GetName(typeof(ArticleType), type);
            return String.Format("\n Id: {0} \n Title: {1} \n Price: {2} \n Category: {3}", id, title, price, articles);
        }
    }
}
