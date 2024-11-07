using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartSmartStudentManagement
{
    public partial class Form1 : Form
    {
        string filepath = Path.Combine(Application.StartupPath, "students.txt");
        string path = Path.Combine(Application.StartupPath, "Report.txt");
        BusinessLogic businessLogic = new BusinessLogic();
        string CID,CName,CAge,CCourse;
        public Form1()
        {
            InitializeComponent();
        }


        public BindingSource bindingSource = new BindingSource();
        public DataTable dt = new DataTable();


        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable studentData = businessLogic.LoadStudentData();
            LoadStudentData();
            AddDeleteButtons();

        }
        public void LoadStudentData()
        {
            var data = businessLogic.LoadStudentData();
            if (data == null || data.Rows.Count == 0)
            {
                DGV_StudentData.DataSource = data;
                MessageBox.Show("Failed to load student data or there is no data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DGV_StudentData.DataSource = data;
                DGV_StudentData.Columns["OriginalID"].Visible = false;
            }
        }
        private void AddDeleteButtons()
        {

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };

            DGV_StudentData.Columns.Add(deleteButtonColumn);
        }


        private void Btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_StudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_StudentData.Rows[e.RowIndex];
                try
                {
                    CID = row.Cells["StudentID"].Value?.ToString();
                    CName = row.Cells["Name"].Value?.ToString();
                    CAge = row.Cells["Age"].Value?.ToString();
                    CCourse = row.Cells["Course"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error accessing values: {ex.Message}");
                }

                if (DGV_StudentData.Columns[e.ColumnIndex].Name == "Delete")
                {
                    btnDelete_Click(e.RowIndex);
                }
            }
        }

        private void btnDelete_Click(int rowIndex)
        {
            string studentID = DGV_StudentData.Rows[rowIndex].Cells["StudentID"].Value?.ToString();
            businessLogic.DeleteStudent(studentID);
            MessageBox.Show("Student record deleted successfully.");
            LoadStudentData(); // Reload data to reflect the deletion

        }

        private void Txt_Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Course_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGV_StudentData_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_StudentData.SelectedRows.Count > 0)
            {
                // Get the selected row as a DataGridViewRow object
                DataGridViewRow row = DGV_StudentData.SelectedRows[0];
                CID = row.Cells[0].Value?.ToString() ?? string.Empty;
                CName = row.Cells[1].Value?.ToString() ?? string.Empty;
                CAge = row.Cells[2].Value?.ToString() ?? string.Empty;
                CCourse = row.Cells[3].Value?.ToString() ?? string.Empty;

            }
            else
            {
                // Clear the textboxes if no row is selected
                Txt_StudentID.Clear();
                Txt_Name.Clear();
                Txt_Age.Clear();
                Txt_Course.Clear();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm(CID,CName,CAge,CCourse, this);

            //non-modal window (can interact with both forms)
            updateForm.Show();
            this.Hide();
            //modal window (blocks interaction with MainForm until UpdateForm is closed)
            //updateForm.ShowDialog();
        }

        private void Btn_Report_Click(object sender, EventArgs e)
        {
            businessLogic.GenerateReport();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
