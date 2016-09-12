using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TestingSystem
{
    class TestController
    {
        TestManager tm;

        public TestController()
        {
            tm = new TestManager();
        }

        public void Add()
        {
            try
            {
                //bool allow_continue = true;
                //string ans;

                Test t = new Test();
                Console.Write(" Test title: ");
                t.Title = Convert.ToString(Console.ReadLine());

                //Console.Write(" Add new question? (y/n)");
                //ans = Convert.ToString(Console.ReadLine());
                //if (ans == "y") {
                //    allow_continue = true;
                //} else {
                //    allow_continue = false;
                //}

                //if (allow_continue)
                //{
                //do
                //{

                //} while (allow_continue);
                //}

                Question q = new Question();
                Console.Write(" Question title: ");
                q.Title = Convert.ToString(Console.ReadLine());

                Answer[] answers = { new Answer(), new Answer(), new Answer(), new Answer() };
                uint right_ans_num;
                Console.Write(" Answer 1: ");
                answers[0].Title = Convert.ToString(Console.ReadLine());
                Console.Write(" Answer 2: ");
                answers[1].Title = Convert.ToString(Console.ReadLine());
                Console.Write(" Answer 3: ");
                answers[2].Title = Convert.ToString(Console.ReadLine());
                Console.Write(" Answer 4: ");
                answers[3].Title = Convert.ToString(Console.ReadLine());

                Console.Write(" Number of right answer: ");
                right_ans_num = Convert.ToUInt32(Console.ReadLine());
                answers[right_ans_num - 1].Right = true;

                q.addAnswers(answers);
                t.addQuestion(q);
                tm.addTest(t);

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR]: {0}", ex.Message);
                Console.ResetColor();
            }
        }

        public void ShowTests()
        {
            tm.ConsoleWrite();
        }

        public void ShowQuestions()
        {
            tm.ConsoleWrite();
        }
    }
}
