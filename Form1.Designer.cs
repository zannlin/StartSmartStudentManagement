﻿namespace StartSmartStudentManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_StudentID = new System.Windows.Forms.TextBox();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_Age = new System.Windows.Forms.TextBox();
            this.Txt_Course = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Report = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "StudentID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CourseID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Txt_StudentID
            // 
            this.Txt_StudentID.Location = new System.Drawing.Point(115, 47);
            this.Txt_StudentID.Name = "Txt_StudentID";
            this.Txt_StudentID.Size = new System.Drawing.Size(269, 20);
            this.Txt_StudentID.TabIndex = 4;
            this.Txt_StudentID.TextChanged += new System.EventHandler(this.Txt_StudentID_TextChanged);
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(115, 80);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(269, 20);
            this.Txt_Name.TabIndex = 5;
            this.Txt_Name.TextChanged += new System.EventHandler(this.Txt_Name_TextChanged);
            // 
            // Txt_Age
            // 
            this.Txt_Age.Location = new System.Drawing.Point(115, 114);
            this.Txt_Age.Name = "Txt_Age";
            this.Txt_Age.Size = new System.Drawing.Size(269, 20);
            this.Txt_Age.TabIndex = 6;
            this.Txt_Age.TextChanged += new System.EventHandler(this.Txt_Age_TextChanged);
            // 
            // Txt_Course
            // 
            this.Txt_Course.Location = new System.Drawing.Point(115, 149);
            this.Txt_Course.Name = "Txt_Course";
            this.Txt_Course.Size = new System.Drawing.Size(269, 20);
            this.Txt_Course.TabIndex = 7;
            this.Txt_Course.TextChanged += new System.EventHandler(this.Txt_Course_TextChanged);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(49, 197);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(95, 23);
            this.Btn_Add.TabIndex = 8;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(150, 197);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(95, 23);
            this.Btn_Update.TabIndex = 9;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Report
            // 
            this.Btn_Report.Location = new System.Drawing.Point(250, 197);
            this.Btn_Report.Name = "Btn_Report";
            this.Btn_Report.Size = new System.Drawing.Size(134, 23);
            this.Btn_Report.TabIndex = 10;
            this.Btn_Report.Text = "Generate Report";
            this.Btn_Report.UseVisualStyleBackColor = true;
            this.Btn_Report.Click += new System.EventHandler(this.Btn_Report_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Start Smart Student Management";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 416);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Report);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Txt_Course);
            this.Controls.Add(this.Txt_Age);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Txt_StudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "StudentID";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_StudentID;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_Age;
        private System.Windows.Forms.TextBox Txt_Course;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Report;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}

