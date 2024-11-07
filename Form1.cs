using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StartSmartStudentManagement
{
    public partial class Form1 : Form
    {
        private BusinessLogicClass businessLogic;

        public Form1()
        {
            InitializeComponent();
            businessLogic = new BusinessLogicClass();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string studentID = Txt_StudentID.Text;
            string name = Txt_Name.Text;
            int age = int.Parse(Txt_Age.Text);
            string course = Txt_Course.Text;

            businessLogic.AddStudent(studentID, name, age, course);
            MessageBox.Show("Student added successfully!");
            
            Txt_StudentID.Clear();
            Txt_Name.Clear();
            Txt_Age.Clear();
            Txt_Course.Clear();

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

        }

        private void Btn_Report_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = businessLogic.GetAllStudents();
            DGV_StudentData.DataSource = dt;
        }

       
        private void ClearFields()
        {
            Txt_StudentID.Clear();
            Txt_Name.Clear();
            Txt_Age.Clear();
            Txt_Course.Clear();
        }

    }
}

