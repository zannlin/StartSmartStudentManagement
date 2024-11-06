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
        string filepath = Path.Combine(Application.StartupPath, "students.txt");
        string path = Path.Combine(Application.StartupPath, "Report.txt");
        BusinessLogic businessLogic = new BusinessLogic();

        public UpdateForm()
        {
            InitializeComponent();
        }

        public BindingSource bindingSource = new BindingSource();
        public DataTable dt = new DataTable();

       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            DataTable studentData = businessLogic.LoadStudentData(filepath);
            LoadStudentData();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchID = txt_Search.Text;

            DataRow[] rows = dt.Select("StudentID = '" + searchID + "'");

           dt.Rows.Clear();
            dt.Rows.Add(rows[0]);
        }

        private void btn_CancelUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_UpdateCom_Click(object sender, EventArgs e)
        {

        }

        private void LoadStudentData()
        {
            var data = businessLogic.LoadStudentData(filepath);
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
    }
}
