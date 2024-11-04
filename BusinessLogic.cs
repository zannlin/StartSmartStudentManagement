using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartSmartStudentManagement
{
    internal class BusinessLogic
    {

        public List<string> GenerateReport(string path, string reportPath)
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
            FileHandler.Overwrite(reportPath, results);


            return results;
        }

    }
}
