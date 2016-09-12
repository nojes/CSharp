using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_TestingSystem
{
    public class Answer : EntityBase
    {
        string title;
        bool right;

        public bool Right
        {
            get { return right; }
            set { right = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public override string ToString()
        {
            string str = "";
            if (right) {
                str = String.Format(" {0} *", title);
            }
            else {
                str = String.Format(" {0}", title);
            }
            return base.ToString() + str;
        }
    }
}