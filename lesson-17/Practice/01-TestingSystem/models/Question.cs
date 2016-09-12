using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_TestingSystem
{
    public class Question : EntityBase
    {
        List<Answer> answers;
        string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public void addAnswer(Answer a)
        {
            answers.Add(a);
        }

        public void addAnswers(Answer[] new_answers)
        {
            foreach (Answer a in new_answers)
            {
                answers.Add(a);
            }
        }

        public override string ToString()
        {
            string str = "";
            str = String.Format(" Question '{0}'", title);
            foreach (Answer a in answers)
            {
                str += a.ToString();
            }

            return base.ToString() + str;
        }
    }
}