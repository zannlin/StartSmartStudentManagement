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
using System.Xml.Linq;

namespace StartSmartStudentManagement
{
    public partial class UpdateForm : Form
    {
        public Form1 mainForm;
        string filepath = Path.Combine(Application.StartupPath, "students.txt");
        BusinessLogic businessLogic = new BusinessLogic();
        DataTable studentData;
        string ID, SName, Age, Course;

        public UpdateForm(string CID, string CName, string CAge, string CCourse, Form1 form1)
        {
            InitializeComponent();
            this.Load += UpdateForm_Load;
            ID = CID;
            SName = CName;
            Age = CAge;
            Course = CCourse;
            mainForm = form1;
        }

        public BindingSource bindingSource = new BindingSource();


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            studentData = businessLogic.LoadStudentData();
            dvg_studentInfo.DataSource = studentData;
            LoadStudentData();
            txt_newStudentID.Text = ID;
            txt_newName.Text = SName;
            txt_newAge.Text = Age;
            txt_newCourseID.Text = Course;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
        }

        private void btn_CancelUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void LoadStudentData()
        {
            var data = businessLogic.LoadStudentData();
            if (data == null || data.Rows.Count == 0)
            {
                dvg_studentInfo.DataSource = data;
                MessageBox.Show("Failed to load student data or there is no data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                dvg_studentInfo.DataSource = data;
                dvg_studentInfo.Columns["OriginalID"].Visible = false;
            }
        }

        private void dvg_studentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dvg_studentInfo_SelectionChanged(object sender, EventArgs e)
        {
            if (dvg_studentInfo.SelectedRows.Count > 0)
            {
                // Get the selected row as a DataGridViewRow object
                DataGridViewRow row = dvg_studentInfo.SelectedRows[0];

                // Assign the cell values to the textboxes
                txt_newStudentID.Text = row.Cells[0].Value?.ToString() ?? string.Empty;
                txt_newName.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                txt_newAge.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                txt_newCourseID.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
            }
            else
            {
                // Clear the textboxes if no row is selected
                txt_newStudentID.Clear();
                txt_newName.Clear();
                txt_newAge.Clear();
                txt_newCourseID.Clear();
            }
        }

        private void btn_UpdateCom_Click(object sender, EventArgs e)
        {

            string studentID = txt_newStudentID.Text;
            string name = txt_newName.Text;
            string age = txt_newAge.Text;
            string course = txt_newCourseID.Text;
            businessLogic.UpdateStudentRecord(studentID, name, age, course);
            mainForm.LoadStudentData();
            mainForm.Show();
            this.Close();

        }

        private void SearchStudent(string searchID, DataTable dataTable)
        {
            DataRow[] rows = dataTable.Select("StudentID = '" + searchID + "'");

            if (rows.Length > 0)
            {
                DataTable filteredTable = dataTable.Clone();  // Copy the structure of `dataTable`
                foreach (DataRow row in rows)
                {
                    filteredTable.ImportRow(row);
                }
                dvg_studentInfo.DataSource = filteredTable;
            }
            else
            {
                MessageBox.Show("No student found with the given ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dvg_studentInfo.DataSource = dataTable;  // Reset to display all students if none are found
            }
        }
        private void btn_SearchN_Click(object sender, EventArgs e)
        {
            SearchStudent(txt_Search.Text.Trim(), studentData);
        }
    }
}
