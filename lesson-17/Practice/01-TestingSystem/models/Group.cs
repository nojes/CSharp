using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_TestingSystem
{
    public class Group : EntityBase
    {
        string name;
        List<Student> students;

        void addStudent(Student s)
        {
            students.Add(s);
        }
    }
}