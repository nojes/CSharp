using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_TestingSystem
{
    public class TestManager
    {
        List<Test> tests;

        public void addTest(Test t)
        {
            tests.Add(t);
        }

        public void removeTest(Test t)
        {
            tests.Remove(t);
        }

        public void ConsoleWrite()
        {
            foreach (Test t in tests)
            {
                Console.WriteLine(" {0}", t.ToString());

            }
        }
    }
}