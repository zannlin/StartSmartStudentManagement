using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace StartSmartStudentManagement
{
    internal class BusinessLogic
    {
        string path = Path.Combine(Application.StartupPath, "Report.txt");
        string filepath = Path.Combine(Application.StartupPath, "students.txt");

        public DataTable LoadStudentData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("StudentID", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Age", typeof(int));
            dataTable.Columns.Add("Course", typeof(string));
            dataTable.Columns.Add("OriginalID", typeof(string)); // To track original ID for updates

            var students = FileHandler.Read(filepath);
            foreach (var student in students)
            {
                var fields = student.Split(',');
                if (fields.Length >= 4)
                    dataTable.Rows.Add(fields[0], fields[1], int.Parse(fields[2]), fields[3], fields[0]);
            }

            return dataTable;
        }
        public void UpdateStudentRecord(string studentID, string name, string age, string course)
        {
            var students = FileHandler.Read(filepath);
            bool found = false;

            for (int i = 0; i < students.Count; i++)
            {
                // Here we're comparing the original ID to find the student to update
                if (students[i].StartsWith(studentID + ","))
                {
                    // Update the student data with the new values
                    students[i] = $"{studentID},{name},{age},{course}";
                    found = true;
                    break;
                }
            }

            if (found)
            {
                FileHandler.Overwrite(filepath, students);
                MessageBox.Show("Record Updated successfully");
            }
            else
            {
                MessageBox.Show("Student ID not found, unable to update record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteStudent (string studentID)
        {
            var students = FileHandler.Read(filepath);
            students = students.Where(line => !line.StartsWith(studentID + ",")).ToList();
            FileHandler.Overwrite(filepath, students);
        }

        public List<string> GenerateReport()
        {
            List<string> students = FileHandler.Read(path);
            int numStudents = 0;
            int totalAge = 0;

            foreach (string student in students)
            {
                string[] details = student.Split(',');
                numStudents++;
                totalAge += int.Parse(details[2]);
            }

            List<string> results = new List<string>();
            results.Add($"Total students: {numStudents}");
            results.Add($"Average age: {totalAge / numStudents}");
            FileHandler.Overwrite(path, results);


            return results;
        }

    }
}
