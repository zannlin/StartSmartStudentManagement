﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }


        public BindingSource bindingSource = new BindingSource();
        public DataTable dt = new DataTable();


        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable studentData = businessLogic.LoadStudentData(filepath);
            LoadStudentData();
            AddEditDeleteButtons();

        }
        private void LoadStudentData()
        {
            var data = businessLogic.LoadStudentData(filepath);
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
        private void AddEditDeleteButtons()
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };

            DGV_StudentData.Columns.Add(editButtonColumn);
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
                if (DGV_StudentData.Columns[e.ColumnIndex].Name == "Update")
                {
                    btnEdit_Click(e.RowIndex);
                }
                else if (DGV_StudentData.Columns[e.ColumnIndex].Name == "Delete")
                {
                    btnDelete_Click(e.RowIndex);
                }
            }
        }
        private void btnEdit_Click(int rowIndex)
        {
            var selectedRow = DGV_StudentData.Rows[rowIndex];
            businessLogic.UpdateStudentRecord(selectedRow, filepath);
            LoadStudentData(); // Reload data to reflect the update
            MessageBox.Show("Student record updated successfully.");
        }

        private void btnDelete_Click(int rowIndex)
        {
            string studentID = DGV_StudentData.Rows[rowIndex].Cells["StudentID"].Value?.ToString();
            businessLogic.DeleteStudent(filepath, studentID);
            MessageBox.Show("Student record deleted successfully.");
            LoadStudentData(); // Reload data to reflect the deletion

        }

        private void Txt_Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Course_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();

            //non-modal window (can interact with both forms)
            updateForm.Show();

            //modal window (blocks interaction with MainForm until UpdateForm is closed)
            // updateForm.ShowDialog();
        }

        private void Btn_Report_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
