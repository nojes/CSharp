using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_TestingSystem
{
    public class Test : EntityBase
    {
        string title;
        List<Question> questions;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public void addQuestion(Question q)
        {
            questions.Add(q);
        }

        public void removeQuestion(Question q)
        {
            questions.Remove(q);
        }

        public override string ToString()
        {
            string str = "";
            str = String.Format(" Test '{0}'", title);
            foreach (Question q in questions)
            {
                str += q.ToString();
            }

            return base.ToString() + str;
        }
    }
}