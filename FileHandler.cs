using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartSmartStudentManagement
{
    static internal class FileHandler
    {
        public static List<string> Read(string filepath)
        {
            List<string> lines = new List<string>();
            
            if (!File.Exists(filepath))
            {
                File.Create(filepath).Dispose();
                return lines;
            }

            if (File.Exists(filepath))
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                    return lines;
                }
            }
            return lines;
        }

        //Append to existing file
        public static void Write(string filepath, string newLine)
        {
            using (StreamWriter writer = new StreamWriter(filepath, append: true))
            {
                {
                    writer.WriteLine(newLine);
                }
            }
        }

        //Completely overwrite existing file
        public static void Overwrite(string filepath, List<string> lines)
        {
            using (StreamWriter writer = new StreamWriter(filepath, append: false))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
