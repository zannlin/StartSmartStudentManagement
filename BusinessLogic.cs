using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;

namespace StartSmartStudentManagement
{
    public class Students
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Students(string studentID, string name, int age, string course)
        {
            StudentID = studentID;
            Name = name;
            Age = age;
            Course = course;
        }
    }

    public class BusinessLogicClass
    {
        public void AddStudent(string studentID, string name, int age, string course)
        {
            Student newStudent = new Student(studentID, name, age, course);
            SaveStudentToFile(newStudent);
        }

       
        public DataTable GetAllStudents()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Student ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Course");

            if (File.Exists(Program.studentsFilePath))
            {
                string[] lines = File.ReadAllLines(Program.studentsFilePath);
                foreach (string line in lines)
                {
                    string[] details = line.Split(',');
                    dt.Rows.Add(details[0], details[1], details[2], details[3]);
                }
            }
            return dt;
        }

        
        private void SaveStudentToFile(Student student)
        {
            using (StreamWriter writer = File.AppendText(Program.studentsFilePath))
            {
                writer.WriteLine($"{student.StudentID},{student.Name},{student.Age},{student.Course}");

            }

        }
        }

    }
