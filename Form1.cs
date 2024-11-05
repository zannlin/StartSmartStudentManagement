using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartSmartStudentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public BindingSource bindingSource = new BindingSource();
        public DataTable dt = new DataTable();


        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("StudentID", typeof(double));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            dt.Columns.Add("CourseID", typeof(string));          
            

            bindingSource.DataSource = dt;
            DGV_StudentData.DataSource = bindingSource;
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
