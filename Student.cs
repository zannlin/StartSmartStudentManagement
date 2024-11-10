using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartSmartStudentManagement
{
    internal class Student
    {
        double _studentID;
        string _name;
        int _age;
        string _course;

        public double StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        { 
            get { return _age; }
            set { _age = value; }
        }

        public string Course
        {
            get { return _course; }
            set { _course = value; }
        }

        public Student(double studentID, string name, int age, string course)
        {
            StudentID = studentID;
            Name = name;
            Age = age;
            Course = course;
        }
    }
}
