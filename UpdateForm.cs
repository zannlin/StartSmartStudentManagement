using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartSmartStudentManagement
{
    public partial class UpdateForm : Form
    {
        string filepath = Path.Combine(Application.StartupPath, "students.txt");
        BusinessLogic businessLogic = new BusinessLogic();

        public UpdateForm(string CID,string CName,string CAge,string CCourse)
        {
            InitializeComponent();
            txt_newStudentID.Text = CID;
            txt_newName.Text = CName;
            txt_newAge.Text = CAge;
            txt_newCourseID.Text = CCourse;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_UpdateCom_Click(object sender, EventArgs e)
        {
            string studentID = txt_newStudentID.Text;
            string name = txt_newName.Text;
            string age = txt_newAge.Text;
            string course = txt_newCourseID.Text;
            businessLogic.UpdateStudentRecord(studentID, name, age, course);
            this.Close();

        }
    }
}
